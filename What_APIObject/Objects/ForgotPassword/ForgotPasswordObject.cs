using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using What_APIObject.Entities.Accounts;
using What_Common.Resources;
using What_APIObject.Entities.ForgotPassword;

namespace What_APIObject.Objects.ForgotPassword
{
    public class ForgotPasswordObject
    {
        public WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;

        public ForgotPasswordObject(User user)
        {
            client = new WHATClient(user);
        }

        public ForgotPasswordModel CreateRequestToForgotPassword(string email)
        {
            ForgotPasswordModel forgotPasswordModel = new ForgotPasswordModel()
            {
                Email = email,
                FormUrl = Resources.WhatForgotPasswordUrl
            };
            return forgotPasswordModel;
        }

        public ForgotPasswordObject VerifyForgotPasswordRequest_Success()
        {
            uri = new Uri(Endpoints.Accounts.accountsPasswordForgot, UriKind.Relative);
            var response = client.Post<ForgotPasswordModel, ForgotPasswordModel>(uri, CreateRequestToForgotPassword(Resources.ForgotPassword.existEmail), out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        public ForgotPasswordObject VerifyForgotPasswordRequest_NotFound()
        {
            uri = new Uri(Endpoints.Accounts.accountsPasswordForgot, UriKind.Relative);
            var response = client.Post<ForgotPasswordModel, ForgotPasswordModel>(uri, CreateRequestToForgotPassword(Resources.ForgotPassword.doesntExistEmail), out statusCode);
            Assert.AreEqual(HttpStatusCode.NotFound, statusCode);
            return this;
        }

        public ForgotPasswordObject VerifyForgotPasswordRequest_BadRequest()
        {
            uri = new Uri(Endpoints.Accounts.accountsPasswordForgot, UriKind.Relative);
            ForgotPasswordModel forgotPasswordObject = CreateRequestToForgotPassword(Resources.ForgotPassword.existEmail);
            forgotPasswordObject.FormUrl = forgotPasswordObject.Email;
            var response = client.Post<ForgotPasswordModel, ForgotPasswordModel>(uri, forgotPasswordObject, out statusCode);
            Assert.AreEqual(HttpStatusCode.BadRequest, statusCode);
            return this;
        }
    }
}

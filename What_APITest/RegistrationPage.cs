using API;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using What_APITest.Entities.Accounts;

namespace What_APITest
{
    public class RegistrationPage
    {
        WHATClient client;
        Uri uri;
        HttpStatusCode statusCode;
        public RegistrationPage VerifyRegistration()
        {
            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegistrationDto>(uri,out statusCode);    
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
        public RegistrationPage AddNewUser(RegistrationNewUser newUser)
        {
            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegistrationNewUser, RegistrationDto>(uri, newUser, out statusCode);

            //newLessonInSystem = response;

            return this;
        }
    }
}

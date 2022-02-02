using NUnit.Framework;
using System;
using What_Common.DataProvider;
using What_APIObject;
using What_APIObject.Objects.Secretaries;
using What_APIObject.Entities.Accounts;
using What_Common.Utils;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Allure.Commons;
using What_Common.Resources;
using System.Net;
using What_APIObject.Objects.ForgotPassword;

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class Success : BaseTest
    {
        [Test(Description = "ForgotPasswordTests")]
        [AllureTag("APITests")]
        [AllureSuite("ForgotPassword")]
        [AllureSubSuite("POST")]
        public void VerifySendingChangePasswordRequest_Success()
        {
            ForgotPasswordObject forgotPasswordObjest = new ForgotPasswordObject(null);
            forgotPasswordObjest.VerifyForgotPasswordRequest_Success();
        }
    }
}
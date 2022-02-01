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

// pass
// admin

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class POST_CreateSecretary_Success : BaseTest
    {
        SecretariesObject secretariesObject;

        [Test(Description = "SecretariesTests")]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("POST")]
        public void VerifyCreateSecretary_Success()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            secretariesObject = new SecretariesObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            secretariesObject.RegistrationNewUser();
            secretariesObject.VerifyCreateNewSecretary(HttpStatusCode.OK);
        }

        [TearDown]
        public void After()
        {
            secretariesObject.DisableSecretary();
        }
    }
}
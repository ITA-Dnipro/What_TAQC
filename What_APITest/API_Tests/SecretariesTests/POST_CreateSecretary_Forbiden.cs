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
// secretary

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class POST_CreateSecretary_Forbiden : BaseTest
    {
        SecretariesObject secretariesObject;

        [Test(Description = "SecretariesTests")]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("POST")]
        public void VerifyCreateSecretary_Forbidden()
        {
            LoginDetails secretary = Controller.GetUser(Controller.UserRole.Secretary);
            secretariesObject = new SecretariesObject(new User { Email = secretary.Email, Password = secretary.Password, Role = Controller.UserRole.Secretary.ToString().ToLower() });
            secretariesObject.RegistrationNewUser();
            secretariesObject.VerifyCreateNewSecretary(HttpStatusCode.Forbidden);
        }

        [TearDown]
        public void After()
        {
            secretariesObject.DisableSecretary();
        }
    }
}
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

// pass!

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class GET_GetAllSecretaries_Unauthorized : BaseTest
    {
        SecretariesObject secretariesObjectAsAdmin;
        AccountUser secretaryAccount;

        [SetUp]
        public void Before()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            secretariesObjectAsAdmin = new SecretariesObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            secretariesObjectAsAdmin.RegistrationNewUser(out secretaryAccount);
            secretariesObjectAsAdmin.CreateNewSecretary(out secretaryAccount);
        }

        [Test(Description = "SecretariesTests")]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("GET")]
        public void VerifyGetAllSecretaries_Unauthorized()
        {
            SecretariesObject secretariesObject = new SecretariesObject(null);
            secretariesObject.VerifyGetAllSecretaries(null, HttpStatusCode.Unauthorized);
        }

        [TearDown]
        public void After()
        {
            secretariesObjectAsAdmin.DisableSecretary(secretaryAccount);
        }
    }
}
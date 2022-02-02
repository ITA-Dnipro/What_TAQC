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
using What_APIObject.Entities.Secretaries;

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class PUT_UpdateSecretary_Unauthorized : BaseTest
    {
        SecretariesObject secretariesObjectAsAdmin;
        AccountUser userAccount;
        SecretariesModel secretariesModel;

        [SetUp]
        public void Before()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            secretariesObjectAsAdmin = new SecretariesObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            secretariesObjectAsAdmin.RegistrationNewUser(out userAccount);
            secretariesObjectAsAdmin.CreateNewSecretary(userAccount, out secretariesModel);
        }

        [Test(Description = "SecretariesTests")]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("PUT")]
        public void VerifyCreateSecretary_Unauthorized()
        {
            SecretariesObject secretariesObjectAsUser = new SecretariesObject(null);
            secretariesObjectAsUser.VerifyUpdateSecretary(secretariesModel, HttpStatusCode.Unauthorized);
        }

        [TearDown]
        public void After()
        {
            secretariesObjectAsAdmin.DisableSecretary(secretariesModel);
        }
    }
}
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
    public class PUT_UpdateSecretary_Forbidden : BaseTest
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
        [TestCase(Controller.UserRole.Student)]
        [TestCase(Controller.UserRole.Mentor)]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("PUT")]
        public void VerifyCreateSecretary_Forbidden(Controller.UserRole userRole)
        {
            LoginDetails user = Controller.GetUser(userRole);
            SecretariesObject secretariesObjectAsUser = new SecretariesObject(new User { Email = user.Email, Password = user.Password, Role = userRole.ToString().ToLower() });
            secretariesObjectAsUser.VerifyUpdateSecretary(secretariesModel, HttpStatusCode.Forbidden);
        }

        [TearDown]
        public void After()
        {
            secretariesObjectAsAdmin.DisableSecretary(secretariesModel);
        }
    }
}
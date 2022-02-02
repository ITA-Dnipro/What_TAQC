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
    public class DELETE_DisableSecretary_Forbidden : BaseTest
    {
        AccountUser secretaryAccount;
        SecretariesModel secretariesModel;

        [SetUp]
        public void Before()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            SecretariesObject secretariesObjectAsAdmin = new SecretariesObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            secretariesObjectAsAdmin.RegistrationNewUser(out secretaryAccount);
            secretariesObjectAsAdmin.CreateNewSecretary(secretaryAccount, out secretariesModel);
        }

        [Test(Description = "SecretariesTests")]
        [TestCase(Controller.UserRole.Secretary)]
        [TestCase(Controller.UserRole.Student)]
        [TestCase(Controller.UserRole.Mentor)]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("DELETE")]
        public void VerifyDisableSecretary_Forbidden(Controller.UserRole userRole)
        {
            LoginDetails user = Controller.GetUser(userRole);
            SecretariesObject secretariesObjectAsUser = new SecretariesObject(new User { Email = user.Email, Password = user.Password, Role = userRole.ToString().ToLower() });
            secretariesObjectAsUser.VerifyDisableSecretary(secretariesModel, HttpStatusCode.Forbidden);
        }
    }
}
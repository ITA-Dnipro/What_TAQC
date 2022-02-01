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
    public class POST_CreateSecretary_Forbidden : BaseTest
    {
        SecretariesObject secretariesObjectAsAdmin;
        AccountUser secretaryAccount;

        [Test(Description = "SecretariesTests")]
        [TestCase(Controller.UserRole.Secretary)]
        [TestCase(Controller.UserRole.Student)]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("POST")]
        public void VerifyCreateSecretary_Forbidden(Controller.UserRole userRole)
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            secretariesObjectAsAdmin = new SecretariesObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            secretariesObjectAsAdmin.RegistrationNewUser(out secretaryAccount);

            LoginDetails user = Controller.GetUser(userRole);
            SecretariesObject secretariesObjectAsUser = new SecretariesObject(new User { Email = user.Email, Password = user.Password, Role = userRole.ToString().ToLower() });
            secretariesObjectAsUser.VerifyCreateNewSecretary(secretaryAccount, HttpStatusCode.Forbidden);
        }

        [TearDown]
        public void After()
        {
            secretariesObjectAsAdmin.DisableSecretary(secretaryAccount);
        }
    }
}
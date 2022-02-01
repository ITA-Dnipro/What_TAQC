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

// FINALY

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class PUT_UpdateSecretary_Success : BaseTest
    {
        SecretariesObject secretariesObjectAsAdmin;
        AccountUser userAccount;
        SecretariesModel secretaryAccount;

        [Test(Description = "SecretariesTests")]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("PUT")]
        public void VerifyCreateSecretary_Success()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            secretariesObjectAsAdmin = new SecretariesObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            secretariesObjectAsAdmin.RegistrationNewUser(out userAccount);
            secretariesObjectAsAdmin.CreateNewSecretary(out secretaryAccount);
            secretariesObjectAsAdmin.VerifyUpdateSecretary(secretaryAccount, HttpStatusCode.OK);
        }

        [TearDown]
        public void After()
        {
            secretariesObjectAsAdmin.DisableSecretary(userAccount);
        }
    }
}
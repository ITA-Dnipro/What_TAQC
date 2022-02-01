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
    public class DELETE_DisableSecretary_Success : BaseTest
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
        [AllureSubSuite("DELETE")]
        public void VerifyDisableSecretary_Success()
        {
            secretariesObjectAsAdmin.VerifyDisableSecretary(secretaryAccount, HttpStatusCode.OK);
        }
    }
}
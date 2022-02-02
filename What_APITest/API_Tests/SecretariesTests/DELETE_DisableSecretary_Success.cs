using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Net;
using What_APIObject.Entities.Accounts;
using What_APIObject.Entities.Secretaries;
using What_APIObject.Objects.Secretaries;
using What_Common.DataProvider;


namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class DELETE_DisableSecretary_Success : BaseTest
    {
        private SecretariesObject secretariesObjectAsAdmin;
        private AccountUser secretaryAccount;
        private SecretariesModel secretariesModel;

        [SetUp]
        public void Before()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            secretariesObjectAsAdmin = new SecretariesObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            secretariesObjectAsAdmin.RegistrationNewUser(out secretaryAccount);
            secretariesObjectAsAdmin.CreateNewSecretary(secretaryAccount, out secretariesModel);
        }

        [Test(Description = "SecretariesTests")]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("DELETE")]
        public void VerifyDisableSecretary_Success()
        {
            secretariesObjectAsAdmin.VerifyDisableSecretary(secretariesModel, HttpStatusCode.OK);
        }
    }
}
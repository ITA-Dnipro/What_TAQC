using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Net;
using What_APIObject.Entities.Accounts;
using What_APIObject.Objects.Secretaries;
using What_Common.DataProvider;

// pass
// admin

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class GET_GetActiveSecretaries_Success : BaseTest
    {
        private SecretariesObject secretariesObject;

        [SetUp]
        public void Before()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            secretariesObject = new SecretariesObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            secretariesObject.RegistrationNewUser();
            secretariesObject.CreateNewSecretary();
        }

        [Test(Description = "SecretariesTests")]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("GET")]
        public void VerifyGetActiveSecretaries_Success()
        {
            secretariesObject.VerifyGetActiveSecretaries(HttpStatusCode.OK);
        }

        [TearDown]
        public void After()
        {
            secretariesObject.DisableSecretary();
        }
    }
}
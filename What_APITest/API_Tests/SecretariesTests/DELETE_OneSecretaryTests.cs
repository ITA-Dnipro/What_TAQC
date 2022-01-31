using NUnit.Framework;
using System;
using What_Common.DataProvider;
using What_APIObject;
using What_APITest.Objects.Secretaries;
using What_APIObject.Entities.Accounts;
using What_Common.Utils;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Allure.Commons;
using What_Common.Resources;

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class DeleteOneSecretary : BaseTest
    {
        SecretariesObject secretariesObject;

        [Test(Description = "SecretariesTests")]
        [TestCase(Controller.UserRole.Admin)]
        //[TestCase(Controller.UserRole.Secretary)]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("DELETE")]
        public void VerifyDisableOneSecretaries(Controller.UserRole role)
        {
            LoginDetails user = Controller.GetUser(role);
            secretariesObject = new SecretariesObject(new User { Email = user.Email, Password = user.Password, Role = role.ToString().ToLower() });
            secretariesObject
                .RegistrationNewUser()
                .CreateNewSecretary()
                .VerifyDisableSecretary();
        }

        [TearDown]
        public void After()
        {
            secretariesObject.client.Dispose();
        }
    }
}
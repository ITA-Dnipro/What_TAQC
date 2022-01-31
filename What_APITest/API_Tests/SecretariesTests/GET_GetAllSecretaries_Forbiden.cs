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
using System.Net;

// problem with credentials

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class GET_GetAllSecretaries_Forbidden : BaseTest
    {
        SecretariesObject secretariesObject;

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
        public void VerifyGetAllSecretaries_Forbidden()
        {
            LoginDetails student = Controller.GetUser(Controller.UserRole.Student);
            SecretariesObject secretariesObjectAsStudent = new SecretariesObject(new User { Email = student.Email, Password = student.Password, Role = Controller.UserRole.Student.ToString().ToLower() });
            secretariesObjectAsStudent.VerifyGetAllSecretaries(HttpStatusCode.Forbidden);
        }

        [TearDown]
        public void After()
        {
            secretariesObject.DisableSecretary();
        }
    }
}
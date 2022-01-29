using NUnit.Framework;
using System;
using What_Common.DataProvider;
using What_APIObject;
using What_APITest.Objects.Secretaries;
using What_APIObject.Entities.Accounts;

namespace What_APITest.API_Tests.SecretariesTests
{
    public class Tests
    {
        SecretariesObject secretariesObject;
        LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);

        [SetUp]
        public void Setup()
        {
            secretariesObject = new SecretariesObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            secretariesObject
                .RegistrationNewUser()
                .CreateNewSecretary();
        }

        [Test]
        public void VerifyGetOneSecretary()
        {
            secretariesObject.VerifyExistSecretary();
        }

        [TearDown]
        public void After()
        {
            secretariesObject.DisableSecretary();
        }
    }
}
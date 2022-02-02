using NUnit.Framework;
using What_Common.DataProvider;
using What_APIObject.Entities.Accounts;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using System.Net;
using What_APIObject.Objects.Students;

namespace What_APITest.API_Tests.StudentsTests
{
    [AllureNUnit]
    [TestFixture]
    public class DELETE_DisableStudent_Success : BaseTest
    {
        StudentsObject studentsObject;

        [SetUp]
        public void Before()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            studentsObject = new StudentsObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            studentsObject.RegisterNewUser();
            studentsObject.CreateNewStudent();
        }

        [Test(Description = "StudentsTests")]
        [AllureTag("APITests")]
        [AllureSuite("Students")]
        [AllureSubSuite("DELETE")]
        public void VerifyDisableStudent_Success()
        {
            studentsObject.VerifyDisableStudent(HttpStatusCode.OK);
        }

        [TearDown]
        public void After()
        {
            studentsObject.DisableStudent();
        }
    }
}

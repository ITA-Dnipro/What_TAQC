using NUnit.Framework;
using What_Common.DataProvider;
using What_APIObject.Objects.Students;
using What_APIObject.Entities.Accounts;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using System.Net;

namespace What_APITest.API_Tests.StudentsTests
{
    [AllureNUnit]
    [TestFixture]
    public class POST_CreateStudent_Forbidden : BaseTest
    {
        StudentsObject studentsObject;

        [Test(Description = "StudentsTests")]
        [AllureTag("APITests")]
        [AllureSuite("Students")]
        [AllureSubSuite("POST")]
        public void VerifyCreateStudent_Forbidden()
        {
            LoginDetails student = Controller.GetUser(Controller.UserRole.Student);
            studentsObject = new StudentsObject(new User { Email = student.Email, Password = student.Password, Role = Controller.UserRole.Student.ToString().ToLower() });
            studentsObject.RegisterNewUser();
            studentsObject.VerifyCreateNewStudent(HttpStatusCode.Forbidden);
        }

        [TearDown]
        public void After()
        {
            studentsObject.DisableStudent();
        }
    }
}

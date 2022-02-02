using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.Entities.Accounts;
using What_APITest.API_Object;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.GroupsAPI_Tests
{

    [TestFixture(Author = "Ivan", Description = "Examples")]
    [AllureNUnit]
    internal class GET_AllStudents_Forbidden
    {
        private LoginDetails user = Controller.GetUser(Controller.UserRole.Student);
        private GroupsAPI_Object students;

        [SetUp]
        public void Setup()
        {
            students = new GroupsAPI_Object(new User { Email = user.Email, Password = user.Password, Role = Controller.UserRole.Student.ToString().ToLower() });
        }

        [Test]
        [AllureTag("APITests")]
        [AllureSuite("Groups")]
        [AllureSubSuite("GET")]

        public void VerifyGroups_Forbidden()
        {
            students.VerifyGetAllStudentsGroupsForbidden();
        }
    }
}
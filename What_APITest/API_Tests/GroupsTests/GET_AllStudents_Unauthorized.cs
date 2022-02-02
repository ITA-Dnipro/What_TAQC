using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APITest.API_Object;

namespace What_APITest.API_Tests.GroupsAPI_Tests
{

    [TestFixture(Author = "Ivan", Description = "Examples")]
    [AllureNUnit]
    internal class GET_AllStudents_Unauthorized
    {
        private GroupsAPI_Object students;

        [SetUp]
        public void Setup()
        {
            students = new GroupsAPI_Object(null);
        }

        [Test]
        [AllureTag("APITests")]
        [AllureSuite("Groups")]
        [AllureSubSuite("GET")]

        public void VerifyGroups_Unauthorized()
        {
            students.VerifyGetAllStudentsGroupsUnauthorized();
        }
    }
}
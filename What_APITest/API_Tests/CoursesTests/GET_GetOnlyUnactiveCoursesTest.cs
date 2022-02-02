using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.Entities.Accounts;
using What_APIObject.Objects.Courses;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.CoursesTests
{
    [AllureNUnit]
    internal class GET_GetOnlyUnactiveCoursesTest : BaseTest
    {
        CourseObject courseObject;

        [SetUp]
        public void Setup()
        {

        }

        [AllureTag("APITests")]
        [AllureSuite("Courses")]
        [AllureSubSuite("GET")]
        [TestCase(Controller.UserRole.Admin, false, Description = "Send GET request to swagger and trying to get all courses as admin")]
        [TestCase(Controller.UserRole.Secretary, false, Description = "Send GET request to swagger and trying to get all courses as secretary")]
        [TestCase(Controller.UserRole.Mentor, false, Description = "Send GET request to swagger and trying to get all courses as mentor")]
        [TestCase(Controller.UserRole.Student, false, Description = "Send GET request to swagger and trying to get all courses as student")]
        [Category("GET request")]
        public void VerifyGetOnlyUnactiveCourses(Controller.UserRole role, bool isActive)
        {
            LoginDetails user = Controller.GetUser(role);
            courseObject = new CourseObject(new User
            {
                Email = user.Email,
                Password = user.Password,
                Role = role.ToString().ToLower()
            });
            courseObject
                .RegistrationNewUser()
                .GetCourses(isActive, System.Net.HttpStatusCode.OK);

        }

        [TearDown]
        public void After()
        {
            courseObject.client.Dispose();
        }
    }
}

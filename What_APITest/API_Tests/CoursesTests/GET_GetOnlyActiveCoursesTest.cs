using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.Entities.Accounts;
using What_APIObject.Objects.Courses;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.CoursesTests
{
    [AllureNUnit]
    internal class GET_GetOnlyActiveCoursesTest : BaseTest
    {
        CourseObject courseObject;

        [SetUp]
        public void Setup()
        {

        }

        [AllureTag("APITests")]
        [AllureSuite("Courses")]
        [AllureSubSuite("GET")]
        [TestCase(Controller.UserRole.Admin, true, Description = "Send GET request to swagger and trying to get all courses as admin")]
        [TestCase(Controller.UserRole.Secretary, true, Description = "Send GET request to swagger and trying to get all courses as secretary")]
        [TestCase(Controller.UserRole.Mentor, true, Description = "Send GET request to swagger and trying to get all courses as mentor")]
        [TestCase(Controller.UserRole.Student, true, Description = "Send GET request to swagger and trying to get all courses as student")]
        [Category("GET request")]
        public void VerifyGetOnlyActiveCourses(Controller.UserRole role, bool isActive)
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

using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.Objects.Courses;

namespace What_APITest.API_Tests.CoursesTests
{
    [AllureNUnit]
    internal class GET_GetAllCoursesUnauthorizedTest : BaseTest
    {
        CourseObject courseObject;

        [SetUp]
        public void Setup()
        {

        }

        [AllureTag("APITests")]
        [AllureSuite("Courses")]
        [AllureSubSuite("GET")]
        [TestCase(null, Description = "Send GET request to swagger and trying to get all courses as unauthorized user")]
        [Category("GET request")]
        public void VerifyUnauthorizedUserCanGetAllCourses(bool isActive)
        {
            courseObject = new CourseObject(null);
            courseObject.GetCourses(isActive, System.Net.HttpStatusCode.Unauthorized);

        }

        [TearDown]
        public void After()
        {
            courseObject.client.Dispose();
        }
    }
}

using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.Entities.Accounts;
using What_APIObject.Entities.Courses;
using What_APIObject.Objects.Courses;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.CoursesTests
{
    [AllureNUnit]
    internal class PATCH_EnableCourseTest : BaseTest
    {
        CourseObject courseObject;
        string oldCourseName;
        [SetUp]
        public void Setup()
        {

        }

        [AllureTag("APITests")]
        [AllureSuite("Courses")]
        [AllureSubSuite("PATCH")]
        [TestCase(Controller.UserRole.Admin, 2, Description = "Send PATCH request to swagger and trying to enable disabled course")]
        [TestCase(Controller.UserRole.Secretary, 3, Description = "Send PATCH request to swagger and trying to enable disabled course")]
        [Category("PATCH request")]
        public void VerifyThatCourseIsUpdate(Controller.UserRole role, CoursesModel model)
        {
            LoginDetails user = Controller.GetUser(role);
            courseObject = new CourseObject(new User
            {
                Email = user.Email,
                Password = user.Password,
                Role = role.ToString().ToLower()
            });

            courseObject.GetCurrentCourse(2);
            courseObject
                .RegistrationNewUser()
                .EnableCourse(id);

        }

        [TearDown]
        public void After()
        {

            courseObject.DisableCourse();
            courseObject.client.Dispose();
        }
    }
}

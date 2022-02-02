using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_APIObject.Entities.Accounts;
using What_APIObject.Objects.Courses;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.CoursesTests
{
    [AllureNUnit]
    internal class PUT_UpdateCourseTest : BaseTest
    {
        CourseObject courseObject;
        string oldCourseName;
        [SetUp]
        public void Setup()
        {

        }

        [AllureTag("APITests")]
        [AllureSuite("Courses")]
        [AllureSubSuite("PUT")]
        [TestCase(Controller.UserRole.Admin, "SoftServeQATest", "labalabadubdub2", Description = "Send PUT request to swagger and trying to update course")]
        [TestCase(Controller.UserRole.Secretary, "SoftServeQATest", "Sec_labalabadubdub2", Description = "Send PUT request to swagger and trying to create new course as student")]
        [Category("PUT request")]
        public void VerifyThatCourseIsUpdate(Controller.UserRole role, string courseName, string newCourseName)
        {
            LoginDetails user = Controller.GetUser(role);
            courseObject = new CourseObject(new User
            {
                Email = user.Email,
                Password = user.Password,
                Role = role.ToString().ToLower()
            });

            //oldCourseName = courseObject.GetCurrentCourse(id);
            courseObject.GetCurrentCourse(13);
            courseObject
                .RegistrationNewUser()
                .CreateNewCourse(courseName, true)
                .UpdateCourse(courseObject.courseId, newCourseName);

        }

        [TearDown]
        public void After()
        {

            courseObject.DisableCourse();
            courseObject.client.Dispose();
        }
    }
}

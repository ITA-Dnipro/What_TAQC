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
    internal class POST_CreateNewCourseNotValidTest : BaseTest
    {
        CourseObject courseObject;

        [SetUp]
        public void Setup()
        {

        }

        [AllureTag("APITests")]
        [AllureSuite("Courses")]
        [AllureSubSuite("POST")]
        [TestCase(Controller.UserRole.Mentor, "mentor_test113", Description = "Send POST request to swagger and trying to create new course as mentor")]
        [TestCase(Controller.UserRole.Student, "student_test113", Description = "Send POST request to swagger and trying to create new course as student")]
        [Category("POST request")]
        public void VerifyIsNewCourseCreateNotValid(Controller.UserRole role, string courseName)
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
                .CreateNewCourse(courseName, false);

        }

        [TearDown]
        public void After()
        {
            courseObject.client.Dispose();
        }
    }
}

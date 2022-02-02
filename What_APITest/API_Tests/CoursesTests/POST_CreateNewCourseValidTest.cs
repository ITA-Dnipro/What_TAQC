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
    internal class POST_CreateNewCourseValidTest : BaseTest
    {
        CourseObject courseObject;

       [SetUp]
        public void Setup()
        {
            
        }

        [AllureTag("APITests")]
        [AllureSuite("Courses")]
        [AllureSubSuite("POST")]
        [TestCase(Controller.UserRole.Admin, "test118", Description = "Send POST request to swagger and create new course as admin")]
        [TestCase(Controller.UserRole.Secretary, "s_test118", Description = "Send POST request to swagger and create new course as secretary")]
        [Category("POST request")]
        public void VerifyIsNewCourseCreateValid(Controller.UserRole role, string courseName)
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
                .CreateNewCourse(courseName, true);

        } 

        [TearDown]
        public void After()
        {
            courseObject.DisableCourse();
            courseObject.client.Dispose();
        }
    }
}

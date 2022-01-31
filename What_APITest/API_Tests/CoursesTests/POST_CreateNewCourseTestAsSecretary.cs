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
    internal class POST_CreateNewCourseTestAsSecretary
    {
        CourseObject courseObject;
        LoginDetails secretary = Controller.GetUser(Controller.UserRole.Admin);

        [SetUp]
        public void Setup()
        {
            courseObject = new CourseObject(new User
            {
                Email = secretary.Email,
                Password = secretary.Password,
                Role = Controller.UserRole.Admin.ToString().ToLower()
            });
            courseObject
                .RegistrationNewUser();

        }

        [Test(Description = "Create new course")]
        public void VerifyIsNewCourseCreate()
        {
            courseObject.CreateNewCourse("s_test105");
        }

        [TearDown]
        public void After()
        {
            courseObject.DisableCourse();
        }
    }
}

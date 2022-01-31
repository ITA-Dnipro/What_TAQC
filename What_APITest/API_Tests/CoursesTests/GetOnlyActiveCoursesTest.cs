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
    internal class GetOnlyActiveCoursesTest : BaseTest
    {
        CourseObject courseObject;
        LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);

        [SetUp]
        public void Setup()
        {
            courseObject = new CourseObject(new User
            {
                Email = admin.Email,
                Password = admin.Password,
                Role = Controller.UserRole.Admin.ToString().ToLower()
            });
            courseObject
                .RegistrationNewUser();

        }

        [Test(Description = "XXX")]
        public void VerifyThatAllCoursesGet()
        {
            courseObject.GetOnlyActiveCourses(true);
        }

        [TearDown]
        public void After()
        {

        }
    }
}

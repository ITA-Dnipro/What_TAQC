using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;
using What_Common.DriverManager;

namespace What_UITest.CourseTest
{
    public class AddNewCourseTest : BaseTest
    {
        SignInPage signInPage;

        CoursesPage coursesPage;

        [SetUp]
        public void Setup()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            signInPage = new SignInPage();
            signInPage.LogIn(admin.Email, admin.Password);
            coursesPage = new BasePageWithSideBar().SidebarNavigateTo<CoursesPage>();
        }

        [Test]
        [TestCase("mycourse5")]
        public void VerifyThatCourseAddToTable(string courseName)
        {
            coursesPage.
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).
                VerifyThatNewCourseCreate(courseName);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Current.Quit();
        }
    }
}

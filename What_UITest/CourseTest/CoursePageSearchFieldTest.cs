using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;
using What_Common.DriverManager;

namespace What_UITest.CourseTest
{
    public class CoursePageSearchFieldTest : BaseTest
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
        [TestCase("So")]
        public void VerifySearchField(string searchingText)
        {
            coursesPage.
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).
                VerifySearchField(searchingText);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Current.Quit();
        }
    }
}

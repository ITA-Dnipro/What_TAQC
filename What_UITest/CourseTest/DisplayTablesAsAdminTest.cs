using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;
using What_Common.DriverManager;

namespace What_UITest.CourseTest
{
    public class DisplayTablesAsAdminTest : BaseTest
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
            //string f = Driver.Current.FindElement(Locators.ListOfCoursesPage.DisabledCoursesCheckbox).GetAttribute("disabled");

        }

        [Test]
        [TestCase("Soft Skills for Lecturers")]
        public void IsDisplayingCoursePage(string expectedResult)
        {
            coursesPage.
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).
                VerifyThatCoursePageDisplayed(expectedResult, 1);
            
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Current.Quit();
        }

    }
}

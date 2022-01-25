using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;
using What_Common.DriverManager;

namespace What_UITest.CourseTest
{
    public class PaginationTest : BaseTest
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

        //[Test]
        //public void IsDisplayingCoursePage(string expectedResult)
        //{
        //    coursesPage.
        //        WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).
        //        //VerifyThatPaginationWork(expectedResult, 1);

        //}

       
    }
}

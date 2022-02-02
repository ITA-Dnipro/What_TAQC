using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;

namespace What_UITest.CourseTest
{
    public class CoursesDetailsTestAsAdmin : BaseTest
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

        
        [TestCase(1)]
        public void IsDisplayingCoursePage(int courseId)
        {
            coursesPage.
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).
                ClickDetailsButtonFromRow(courseId).
                VerifyThatDetailsViewCorrectly();

        }

    }
}

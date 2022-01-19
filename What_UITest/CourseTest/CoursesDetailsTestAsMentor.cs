using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;
using What_Common.DriverManager;

namespace What_UITest.CourseTest
{
    public class CoursesDetailsTestAsMentor : BaseTest
    {
        SignInPage signInPage;

        CoursesPage coursesPage;

        CourseDetailsPage courseDetailsPage;

        [SetUp]
        public void Setup()
        {
            LoginDetails mentor = Controller.GetUser(Controller.UserRole.Mentor);
            signInPage = new SignInPage();
            signInPage.LogIn(mentor.Email, mentor.Password);
            coursesPage = new BasePageWithSideBar().SidebarNavigateTo<CoursesPage>();
            //string f = Driver.Current.FindElement(Locators.ListOfCoursesPage.DisabledCoursesCheckbox).GetAttribute("disabled");

        }

        [Test]
        [TestCase(1)]
        public void IsDisplayingCoursePage(int courseId)
        {
            coursesPage.
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).
                ClickDetailsButtonFromRow(1).
                VerifyThatDetailsViewCorrectly();
            //VerifyThatDetailsViewCorrectly(expectedResult, 1);

        }

    }
}

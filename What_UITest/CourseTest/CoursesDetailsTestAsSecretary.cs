using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;

namespace What_UITest.CourseTest
{
    public class CoursesDetailsTestAsSecretary : BaseTest
    {
        SignInPage signInPage;

        CoursesPage coursesPage;

        [SetUp]
        public void Setup()
        {
            LoginDetails secretary = Controller.GetUser(Controller.UserRole.Secretary);
            signInPage = new SignInPage();
            signInPage.LogIn(secretary.Email, secretary.Password);
            coursesPage = new BasePageWithSideBar().SidebarNavigateTo<CoursesPage>();
            //string f = Driver.Current.FindElement(Locators.ListOfCoursesPage.DisabledCoursesCheckbox).GetAttribute("disabled");

        }

        
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

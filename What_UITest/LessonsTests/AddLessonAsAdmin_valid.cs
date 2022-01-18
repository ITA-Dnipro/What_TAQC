using NUnit.Framework;
using What_Common.DriverManager;
using What_PageObject.Lessons;
using Locators = What_Common.Resources.Locators;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;
using What_PageObject.SignInPage;

namespace What_UITest.Lessons
{
    public class AddLessonAsAdmin_valid : BaseTest
    {
        LessonsPage lessonsPage;
        [SetUp]
        public void Setup()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            Driver.GoToUrl();
            SignInPage signIn = new SignInPage();
            signIn.EnterEmail(admin.Email);
            signIn.EnterPassword(admin.Password);
            signIn.ClickSignInButton();
            lessonsPage = new BasePageWithSideBar().SidebarNavigateTo<LessonsPage>();
        }
        [Test]
        public void AdminCanCreateNewLessons()
        {
            string lessonsTheme = "Advanced Python";
            lessonsPage
                .WaitUntilElementLoads<LessonsPage>(Locators.Lessons.AddLessonButton)
                .ClickAddLessonButton()
                .WaitUntilElementLoads<AddLessonPage>(Locators.AddLesson.MainForm)
                .FillLessonTheme(lessonsTheme)
                .FillGroupName()
                .FillLessonDate()
                .FillMentorEmail()
                .ClickClassRegisterButton()
                .ClickSaveButton()
                .VerifyFlashMessage()
                .VerifyLessonAddedToTable(lessonsTheme);
        }
    }
}

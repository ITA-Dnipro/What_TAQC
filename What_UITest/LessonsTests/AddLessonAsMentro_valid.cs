using NUnit.Framework;
using What_Common.DriverManager;
using What_PageObject.Lessons;
using Locators = What_Common.Resources.Locators;
using What_Common.DataProvider;
using What_PageObject;
using What_PageObject.SignInPage;

namespace What_UITest.Lessons
{
    public class AddLessonAsMentor_valid : BaseTest
    {
        string lessonsTheme = "Advanced Swift";
        LessonsPage lessonsPage;
        string generatedDateTime;


        [SetUp]
        public void Setup()
        {
            LoginDetails mentor = Controller.GetUser(Controller.UserRole.Mentor);
            Driver.GoToUrl();
            SignInPage signIn = new SignInPage();
            signIn.EnterEmail(mentor.Email);
            signIn.EnterPassword(mentor.Password);
            signIn.ClickSignInButton();
            lessonsPage = new BasePageWithSideBar().SidebarNavigateTo<LessonsPage>();
        }

        [Test(Description = "DP220TAQC-191")]
        public void MentorCanCreateNewLessons()
        {

            lessonsPage
                .WaitUntilElementLoads<LessonsPage>(Locators.Lessons.AddLessonButton)
                .ClickAddLessonButton()
                .WaitUntilElementLoads<AddLessonPage>(Locators.AddLesson.MainForm)
                .FillLessonTheme(lessonsTheme)
                .VerifyLessonTheme(lessonsTheme)
                .FillGroupName()
                .VerifyGroupName()
                .FillLessonDate(out generatedDateTime)
                .VerifyLessonDate(generatedDateTime)
                .FillMentorEmail()
                .VerifyMentorEmail()
                .ClickClassRegisterButton()
                .VerifyClassJournal()
                .ClickSaveButton()
                .VerifyFlashMessage()
                .VerifyLessonAddedToTable(lessonsTheme);
        }
    }
}

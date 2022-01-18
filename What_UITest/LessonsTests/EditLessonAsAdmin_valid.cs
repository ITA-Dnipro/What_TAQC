using NUnit.Framework;
using What_Common.DriverManager;
using What_PageObject.Lessons;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;
using What_PageObject.SignInPage;

namespace What_UITest.Lessons
{
    public class EditLessonAsAdmin_valid : BaseTest
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
        public void AdminCanEditLessons()
        {
            LessonsDetailsModel lessonsDetailsModel;
            LessonsDetailsModel actualLessonsDetails;
            string newLessonTheme = "Agile 101";
            new LessonsPage()
                .ClickOnLesson("Java 101")
                .GetAllData(out lessonsDetailsModel)
                .ClickCancelButton()
                .ClicOnEditLesson("Java 101")
                .EditLessonTheme(newLessonTheme)
                .ClickSaveButton()
                .VerifyFlashMessageAppear()
                .ClickOnLesson(newLessonTheme)
                .GetAllData(out actualLessonsDetails)
                .VerifyPageEdited(lessonsDetailsModel, actualLessonsDetails);

        }
    }
}

using NUnit.Framework;
using What_Common.DriverManager;
using What_PageObject.Lessons;
using What_Common.Resources;
using What_PageObject.SignIn;
using What_Common.DataProvider;
using What_PageObject;
using What_PageObject.LessonPage.Models;

namespace What_UITest.Lessons
{
    public class EditLessonAsMentor_valid : BaseTest
    {
        string newLessonTheme = "Agile 101";
        string existingLessonTheme = "Java 101";
        LessonsPage lessonsPage;
        LessonRow lessonRow;
        LessonEditDetails lessonsDetailsModel;
        LessonsDetailsModel actualLessonsDetails;


        [SetUp]
        public void Setup()
        {
            LoginDetails mentor = Controller.GetUser(Controller.UserRole.Mentor);
            Driver.GoToUrl();
            SignInPage signIn = new SignInPage(Driver.Current);
            signIn.EnterEmail(mentor.Email);
            signIn.EnterPassword(mentor.Password);
            signIn.ClickSignInButton(Resources.WhatStudentsUrl);
            lessonsPage = new BasePageWithSideBar().SidebarNavigateTo<LessonsPage>();

        }

        [Test(Description = "DP220TAQC-190")]
        public void MentorCanEditLessons()
        {

            lessonsPage
                .SaveClickedRow(existingLessonTheme, out lessonRow)
                .ClicOnEditLesson(existingLessonTheme)
                .VerifyGroupNameFieldDisabled()
                .VerifyAllInputs(lessonRow)
                .VerifyClassJournalExist()
                .EditLessonTheme(newLessonTheme)
                .SaveAllDataFromEditLesson(out lessonsDetailsModel)
                .ClickSaveButton()
                .VerifyFlashMessageAppear()
                .ClickOnLesson(newLessonTheme)
                .SaveAllDataFromLessonDetails(out actualLessonsDetails)
                .VerifyPageEdited(lessonsDetailsModel, actualLessonsDetails)
                .ClickCancelButton();

        }

        [TearDown]
        public void After()
        {
            new LessonsPage()
                .ClicOnEditLesson(newLessonTheme)
                .EditLessonTheme(existingLessonTheme)
                .ClickSaveButton();
        }
    }
}

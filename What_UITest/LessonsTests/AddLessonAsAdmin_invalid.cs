using NUnit.Framework;
using System.Collections.Generic;
using What_Common.DriverManager;
using What_PageObject.Lessons;
using Locators = What_Common.Resources.Locators;
using What_Common.Resources;
using What_PageObject.SignIn;
using What_Common.DataProvider;
using What_PageObject;
using What_Common.Utils;
using What_PageObject.LessonPage.Models;

namespace What_UITest.Lessons
{
    public class AddLessonAsAdmin_invalid : BaseTest
    {
        LessonsPage lessonsPage;
        [SetUp]
        public void Setup()
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            Driver.GoToUrl();
            SignInPage signIn = new SignInPage(Driver.Current);
            signIn.EnterEmail(admin.Email);
            signIn.EnterPassword(admin.Password);
            signIn.ClickSignInButton(Resources.WhatStudentsUrl);
            lessonsPage = new BasePageWithSideBar().SidebarNavigateTo<LessonsPage>();

        }
        [Test]
        [TestCaseSource(nameof(GetInvalidAddLessons))]
        public void AdminCantCreateLessonWithInvalidData(AddLessonModel invalid)
        {
            lessonsPage
                .WaitUntilElementLoads<LessonsPage>(Locators.Lessons.AddLessonButton)
                .ClickAddLessonButton()
                .WaitUntilElementLoads<AddLessonPage>(Locators.AddLesson.MainForm)
                .FillLessonTheme(invalid.LessonTheme)
                .VerifyLessonsThemeError(invalid.LessonThemeError)
                .FillGroupName(invalid.GroupName)
                .VerifyGroupNameError(invalid.GroupNameError)
                .FillMentorEmail(invalid.MentorEmail)
                .VerifyMentorEmailError(invalid.MentorEmailError);
        }
        private static IEnumerable<AddLessonModel> GetInvalidAddLessons()
        {
            return JsonHelper.ReadJson<AddLessonModel>(Resources.InvalidAddLessonData);
        }
    }
}

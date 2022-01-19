﻿using NUnit.Framework;
using What_Common.DriverManager;
using What_PageObject.Lessons;
using Locators = What_Common.Resources.Locators;
using What_Common.Resources;
using What_PageObject.SignIn;
using What_Common.DataProvider;
using What_PageObject;

namespace What_UITest.Lessons
{
    public class AddLessonAsAdmin_valid : BaseTest
    {
        string lessonsTheme = "Starter Cplusplus";
        LessonsPage lessonsPage;
        string generatedDateTime;


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

        [Test(Description = "DP220TAQC-191")]
        public void AdminCanCreateNewLessons()
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

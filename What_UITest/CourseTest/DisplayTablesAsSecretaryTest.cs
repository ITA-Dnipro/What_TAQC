﻿using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;

namespace What_UITest.CourseTest
{
    public class DisplayTablesAsSecretaryTest : BaseTest
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

        }

        
        [TestCase("Soft Skills for Lecturers")]
        public void IsDisplayingCoursePage(string expectedResult)
        {
            coursesPage.
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).
                VerifyThatCoursePageDisplayed(expectedResult, 1);
        }

    }
}

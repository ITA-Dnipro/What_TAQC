using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.Resources;
using What_Common.DriverManager;
using What_PageObject.Course;
using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;

namespace What_PageObject.StudentsPage
{
    public class StudentsPage : BasePageWithSideBar
    {

        public StudentsPage VerifyCardsSwitchButton()
        {
            ClickElement(Locators.Students.CardsIcon);
            WaitUntilElementLoads<StudentsPage>(Locators.Students.DetailsButton);
            IWebElement detailsText = Driver.Current.FindElement(Locators.Students.DetailsButton);
            string expected = "Details";
            string actual = detailsText.Text;
            Assert.AreEqual(expected, actual);
            return this;
        }

        /// <summary>
        /// Show table of students in row element
        /// </summary>
        /// <returns>Student Page</returns>
        public StudentsPage ClickRowCourseView()
        {
            ClickElement(Locators.Students.ListTable);
            WaitUntilElementLoads<StudentsPage>(Locators.ListOfCoursesPage.CourseTableInRow);
            return this;
        }

        /// <summary>
        /// Click on course on sidebar panel
        /// </summary>
        /// <returns>Course Page</returns>
        public CoursesPage ClickCoursesPage()
        {
            SidebarNavigateTo<CoursesPage>();
            wait.Until(ExpectedConditions.UrlMatches(Resources.WhatCoursesUrl));
            return new CoursesPage(Driver.Current);
        }

        public StudentsPage VerifyListSwitchButton()
        {
            ClickElement(Locators.Students.ListIcon);
            return this;
        }




    }
}

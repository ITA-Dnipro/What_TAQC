using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.Course
{
    public class CourseDetailsPage : BasePage
    {
        private IWebDriver driver;

        private Waiter waiter;

        private string courseName;

        private int courseId;

        public CourseDetailsPage(IWebDriver driver, string courseName, int courseId)
        {
            this.driver = driver;
            this.waiter = new Waiter(driver);
            this.courseName = courseName;
            this.courseId = courseId;
        }

        public EditCoursePage ClickEditCourseTab()
        {
            ClickElement(Locators.CourseDetails.EditCourseDetailsTab);
            waiter.wait.Until(ExpectedConditions.UrlMatches(Resources.WhatCoursesDetailsUrl));
            return new EditCoursePage(driver, courseName, courseId);
        }

        //public CourseDetails ClickCourseDetailsTab()
        //{
        //    ClickElement(Locators.CourseDetails.CourseDetailsTab);
        //    return this;
        //}

        /// <summary>
        /// Redirect you back to course page
        /// </summary>
        /// <returns>Course Page</returns>
        public CoursesPage ArrowClick()
        {
            ClickElement(Locators.CourseDetails.ArrowBackLink);
            return new CoursesPage();
        }

        public bool IsCourseIdCorrect()
        {
            return Equals(driver.FindElement(Locators.CourseDetails.CourseName).Text, courseName);
        }

        /// <summary>
        /// Calling test that check is your Details Page displayed correct
        /// </summary>
        /// <param name="id">Element id</param>
        /// <returns>Course Page </returns>
        public CoursesPage VerifyThatDetailsViewCorrectly()
        {
            string actualResult = driver.FindElement(Locators.CourseDetails.CourseName).Text;
            Assert.Multiple(() =>
            {
            Assert.AreEqual(courseName, actualResult);
            ArrowClick().
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).
                ClickCardCourseView().
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInCards).
                ClickDetailsButtonFromCards(courseId);
            Assert.AreEqual(courseName, actualResult);
            });

            return new CoursesPage();
        }
    }
}
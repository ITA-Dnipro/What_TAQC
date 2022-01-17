using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using What_Common.Resources;
using What_PageObject.MyProfile;

namespace What_PageObject.Course
{
    public class CoursesPage : BasePageWithSideBar
    {

        private IWebDriver driver;

        private Waiter waiter;

        public CoursesPage(IWebDriver driver)
        {
            this.driver = driver;
            this.waiter = new Waiter(driver);
        }

        /// <summary>
        /// Goes to my profile page
        /// </summary>
        /// <returns>My Profile Page</returns>
        public MyProfilePage ClickMyProfileIcon()
        {
            ClickElement(Locators.NavBar.IconLink);
            waiter.wait.Until(ExpectedConditions.UrlMatches(Resources.WhatMyProfileUrl));
            return new MyProfilePage(driver);
        }

        /// <summary>
        /// Show table of courses in row element
        /// </summary>
        /// <returns>CoursePage</returns>
        public CoursesPage ClickRowCourseView()
        {
            ClickElement(Locators.ListOfCoursesPage.CourseDetailsInRowElement);
            WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow);
            return this;
        }

        /// <summary>
        /// Show table of courses in card element
        /// </summary>
        /// <returns>CoursePage</returns>
        public CoursesPage ClickCardCourseView()
        {
            ClickElement(Locators.ListOfCoursesPage.ViewCardsButton);
            WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInCards);
            return this;
        }

        /// <summary>
        /// Click on course on sidebar panel
        /// </summary>
        /// <returns>Course Page</returns>
        public CoursesPage ClickCoursesPage()
        {
            SidebarNavigateTo<CoursesPage>();
            return new CoursesPage(driver);
        }

        /// <summary>
        /// Click left arrow on pagination
        /// </summary>
        /// <returns>Previous page with courses table</returns>
        public CoursesPage ClickPreviousPageOnPagination()
        {
            ClickElement(Locators.ListOfCoursesPage.PreviousButtonPage);
            return this;
        }

        /// <summary>
        /// Clcik right arrow on pagination
        /// </summary>
        /// <returns>Next page with courses table</returns>
        public CoursesPage ClickNextPageOnPagination()
        {
            ClickElement(Locators.ListOfCoursesPage.NextButtonPage);
            return this;
        }
        
        /// <summary>
        /// Inputs text to search field
        /// </summary>
        /// <param name="text">Text to input</param>
        /// <returns>Course Page</returns>
        public CoursesPage SearchByName(string text)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(e => e.FindElements(Locators.ListOfCoursesPage.CourseTableInRow));
            FillField(Locators.ListOfCoursesPage.SearchField, text);
            return this;
        }

        /// <summary>
        /// Redirect you to edit Course Page
        /// </summary>
        /// <param name="courseName">Name of course</param>
        /// <returns>Edit Course Page</returns>
        public EditCoursePage ClickEditButton(string courseName)
        {
            ClickElement(Locators.ListOfCoursesPage.EditCourseElement);
            return new EditCoursePage(driver, courseName);
        }

        /// <summary>
        /// Redirect you to details Course Page from row view
        /// </summary>
        /// <param name="courseName">Name of course</param>
        /// <returns>Course Details Page</returns>
        public CourseDetailsPage ClickDetailsButtonFromRow(string courseName)
        {
            ClickElement(Locators.ListOfCoursesPage.CourseDetailsInRowElement);
            return new CourseDetailsPage(driver, courseName);
        }

        /// <summary>
        /// Redirect you to details Course Page from cards view
        /// </summary>
        /// <param name="courseName">Name of course</param>
        /// <returns>Course Details Page</returns>
        public CourseDetailsPage ClickDetailsButtonFromCards(string courseName)
        {
            ClickElement(Locators.ListOfCoursesPage.DetailsInCardViewButton(1));
            waiter.wait.Until(ExpectedConditions.UrlMatches(Resources.WhatCoursesDetailsUrl));
            return new CourseDetailsPage(driver, courseName);
        }

        /// <summary>
        /// Redirect you to AddCourse page
        /// </summary>
        /// <returns>Add Course Page</returns>
        public AddCoursePage ClickAddCourseButton()
        {
            ClickElement(Locators.ListOfCoursesPage.AddCourseButton);
            return new AddCoursePage(driver);
        }

        ///// <summary>
        ///// Call test that verify is table displayed as rows
        ///// </summary>
        ///// <returns>Course Page</returns>
        //public CoursesPage VerifyThatCourseTableAsRowsDisplayed()
        //{
        //    ClickCoursesPage().WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow);
        //    Assert.AreEqual(Resources.WhatCoursesUrl, driver.Url);
        //    return this;
        //}

        ///// <summary>
        ///// Call test that verify is table displayed as cards
        ///// </summary>
        ///// <returns>Course Page</returns>
        //public CoursesPage VerifyThatCourseTableAsCardsDisplayed()
        //{
        //    ClickCoursesPage().WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).ClickCardCourseView();
        //    Assert.AreEqual(Resources.WhatCoursesUrl, driver.Url);
        //    return this;
        //}

        /// <summary>
        /// Called test that verify is page course displayed correctly 
        /// </summary>
        /// <returns>Course Page</returns>
        public CoursesPage VerifyThatCoursePageDisplayed()
        {
            ClickCoursesPage().WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(Resources.WhatCoursesUrl, driver.Url);
                ClickCardCourseView().WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInCards);
                Assert.AreEqual(Resources.WhatCoursesUrl, driver.Url);
            });
           
            return this;
        }

        //public void MouseHover()
        //{
        //    Actions action = new Actions(driver);
        //    action.MoveByOffset(0, 100);
        //    Thread.Sleep(3000);
        //}

        //public void ClickMentorsMenuItem()
        //{
        //    testelem.Click();
        //}

        //public void LogOut()
        //{
        //    ElemDropdown.Click();
        //    ElemLogout.Click();
        //}
    }
}
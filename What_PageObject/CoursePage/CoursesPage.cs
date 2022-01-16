using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            waiter.wait.Until(ExpectedConditions.UrlMatches("http://localhost:8080/my-profile"));
            return new MyProfilePage(driver);
        }

        /// <summary>
        /// Show table of courses in row element
        /// </summary>
        /// <returns>CoursePage</returns>
        public CoursesPage ClickRowCourseView()
        {
            ClickElement(Locators.ListOfCoursesPage.CourseDetailsInRowElement);
            waiter.wait.Until(ExpectedConditions.UrlMatches("http://localhost:8080/courses/1"));
            return this;
        }

        /// <summary>
        /// Show table of courses in card element
        /// </summary>
        /// <returns>CoursePage</returns>
        public CoursesPage ClickCardCourseView()
        {
            ClickElement(Locators.ListOfCoursesPage.ViewCardsButton);
            waiter.wait.Until(ExpectedConditions.ElementExists(Locators.ListOfCoursesPage.DetailsInCardViewButton));
            ClickElement(Locators.ListOfCoursesPage.DetailsInCardViewButton);
            waiter.wait.Until(ExpectedConditions.UrlMatches("http://localhost:8080/courses/1"));
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
            wait.Until(e => e.FindElements(Locators.ListOfCoursesPage.CourseTable));
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
        /// Redirect you to details Course Page
        /// </summary>
        /// <param name="courseName">Name of course</param>
        /// <returns>Course Details Page</returns>
        public CourseDetailsPage ClickDetailsButton(string courseName)
        {
            ClickElement(Locators.ListOfCoursesPage.CourseDetailsInRowElement);
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
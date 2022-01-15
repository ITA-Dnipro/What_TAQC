using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.Resources;

namespace What_PageObject.Course
{
    public class CoursePage : BasePage
    {

        private IWebDriver driver;

        private Waiter waiter;

        public CoursePage(IWebDriver driver)
        {
            this.driver = driver;
            this.waiter = new Waiter(driver);
        }

        /// <summary>
        /// Goes to my profile page
        /// </summary>
        public void ClickMyProfileIcon()
        {
            ClickElement(Locators.NavBar.IconLink);
            waiter.wait.Until(ExpectedConditions.UrlMatches("http://localhost:8080/my-profile"));
        }

        public void ClickRowCourseDetails()
        {
            ClickElement(Locators.ListOfCoursesPage.CourseInfoElement);
            waiter.wait.Until(ExpectedConditions.UrlMatches("http://localhost:8080/courses/1"));
        }

        public void ClickCardCourseDetails()
        {
            ClickElement(Locators.ListOfCoursesPage.ViewCardsButton);
            waiter.wait.Until(ExpectedConditions.ElementExists(Locators.ListOfCoursesPage.DetailsInCardViewButton));
            ClickElement(Locators.ListOfCoursesPage.DetailsInCardViewButton);
            waiter.wait.Until(ExpectedConditions.UrlMatches("http://localhost:8080/courses/1"));
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
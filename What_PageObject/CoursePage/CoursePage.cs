using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.CoursePage
{
    public class CoursePage
    {
        private IWebDriver driver;


        public CoursePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Goes to my profile page
        /// </summary>
        public void ClickMyProfileIcon()
        {
            //ElemMyProfileIcon.FindElement
            //wait.Until(ExpectedConditions.UrlMatches("http://localhost:8080/my-profile"));
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

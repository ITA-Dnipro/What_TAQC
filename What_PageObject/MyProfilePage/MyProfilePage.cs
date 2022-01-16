using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using What_Common.Resources;

namespace What_PageObject.MyProfile
{
    public class MyProfilePage : BasePage
    {

        private IWebDriver driver;

        private Waiter waiter;

        public MyProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            this.waiter = new Waiter(driver);
        }


        /// <summary>
        /// Click on 'change password' button
        /// </summary>
        public void ChangePasswordClick()
        {
            ClickElement(Locators.MyProfilePage.ChangePasswordButton);
            waiter.wait.Until(ExpectedConditions.UrlMatches("http://localhost:8080/change-password"));
        }

        public string GetFirstName()
        {
            return driver.FindElement(Locators.MyProfilePage.FirstNameField).Text;
        }

        public string GetLastName()
        {
            return driver.FindElement(Locators.MyProfilePage.LastNameField).Text;
        }

        public string GetEmailAddress()
        {
            return driver.FindElement(Locators.MyProfilePage.EmailAddressField).Text;
        }
    }
}
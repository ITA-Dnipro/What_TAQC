using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
// For supporting Page Object Model
// Obsolete - using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace SeleniumTest1
{
    public class BasePage
    {
        const string url = "http://localhost:8080";
        

        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            
        }

        //[FindsBy(How = How.XPath, Using = Locators.SignInPage.LOGIN_FIELD)]
        //[CacheLookup]
        //private IWebElement elem_login_textbox;


        //[FindsBy(How = How.XPath, Using = Locators.SignInPage.PWD_FIELD)]
        //[CacheLookup]
        //private IWebElement elem_password_textbox;

        //[FindsBy(How = How.XPath, Using = Locators.SignInPage.SIGN_IN_BTN)]
        //[CacheLookup]
        //private IWebElement elem_signin_button;

        //private IWebElement elem_login_textbox => driver.FindElement(By.XPath(Locators.SignInPage.LOGIN_FIELD));

        //private IWebElement elem_password_textbox => driver.FindElement(By.XPath(Locators.SignInPage.PWD_FIELD));

        //private IWebElement elem_signin_button => driver.FindElement(By.XPath(Locators.SignInPage.SIGN_IN_BTN));

        /// <summary>
        /// Go to the designated page
        /// </summary>
        public void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Returns the search string
        /// </summary>
        /// <returns>Page title</returns>
        public string GetPageTitle()
        {
            return driver.Title;
        }

    }
}

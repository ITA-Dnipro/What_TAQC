using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;


namespace What_PageObject.SignInPage
{
    public class SignInPageObject
    {
        private IWebDriver driver;
        private Waiter waiter;

       
        public SignInPageObject(IWebDriver driver)
        {
            this.driver = driver;
            waiter = new Waiter(driver);
        }

        public bool atPage()
        {
            if (driver.Url.Equals("http://localhost:8080/auth"))
            {
                return true;
            }
            return false;
        }

        public SignInPageObject EnterEmail(string email)
        {
            driver.FindElement(Locators.EmailField).SendKeys(email);
            return this;
        }

        public SignInPageObject EnterPassword(string password)
        {
            driver.FindElement(Locators.PasswordField).SendKeys(password);
            return this;
        }

        public SignInPageObject ClickSignInButton(string url)
        {
            driver.FindElement(Locators.SignInButton).Click();
            waiter.wait.Until(ExpectedConditions.UrlMatches(url));
            return this;
        }

        public SignInPageObject LogIn(string email, string password, string url)
        {
            EnterEmail(email);
            EnterPassword(password);
            return ClickSignInButton(url);
        }
    }
}

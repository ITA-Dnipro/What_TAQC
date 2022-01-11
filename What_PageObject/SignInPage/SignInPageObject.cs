using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        


        private WebDriver driver;

        public SignInPageObject(WebDriver driver)
        {
            this.driver = driver;
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

        public SignInPageObject ClickSIgnInButton()
        {
            driver.FindElement(Locators.SignInButton).Click();
            return this;
        }

        public SignInPageObject LogIn(string email, string password)
        {
            EnterEmail(email);
            EnterPassword(password);
            return ClickSIgnInButton();
        }
    }
}

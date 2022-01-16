using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using What_Common.Resources;


namespace What_PageObject.SignInPage
{
    public class SignInPage : BasePage
    {
        private IWebDriver driver;
        private Waiter waiter;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            waiter = new Waiter(driver);
        }

        public bool IsAtPage()
        {
            if (driver.Url.Equals("http://localhost:8080/auth"))
            {
                return true;
            }
            return false;
        }

        #region LogIn
        public SignInPage EnterEmail(string email)
        {
            driver.FindElement(Locators.SignIn.EmailField).SendKeys(email);
            return this;

        }

        public SignInPage EnterPassword(string password)
        {
            driver.FindElement(Locators.SignIn.PasswordField).SendKeys(password);
            return this;
        }

        public SignInPage ClickSignInButton(string url)
        {
            driver.FindElement(Locators.SignIn.SignInButton).Click();
            waiter.wait.Until(ExpectedConditions.UrlMatches(url));
            return this;
        }

        public SignInPage LogIn(string email, string password, string url)
        {
            EnterEmail(email);
            EnterPassword(password);
            return ClickSignInButton(url);
        }
        #endregion

        public SignInPage ClickRegistrationButton()
        {
            driver.FindElement(Locators.SignIn.RegistrationButton).Click();
            return this;
        }

        public SignInPage ClickForgotPasswordButton()
        {

            driver.FindElement(Locators.SignIn.ForgotPasswordButton).Click();
            return this;
        }
    }
}

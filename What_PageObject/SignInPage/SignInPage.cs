using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using What_Common.Resources;
using What_Common.DriverManager;


namespace What_PageObject.SignInPage
{
    public class SignInPage : BasePage
    {

        public bool IsAtPage()
        {
            if (Driver.Current.Equals("http://localhost:8080/auth"))
            {
                return true;
            }
            return false;
        }

        #region LogIn
        public SignInPage EnterEmail(string email)
        {
            Driver.Current.FindElement(Locators.SignIn.EmailField).SendKeys(email);
            return this;

        }

        public SignInPage EnterPassword(string password)
        {
            Driver.Current.FindElement(Locators.SignIn.PasswordField).SendKeys(password);
            return this;
        }

        public SignInPage ClickSignInButton()
        {
            Driver.Current.FindElement(Locators.SignIn.SignInButton).Click();
            return this;
        }

        public SignInPage LogIn(string email, string password)
        {
            EnterEmail(email);
            EnterPassword(password);
            return ClickSignInButton();
        }
        #endregion

        public SignInPage ClickRegistrationButton()
        {
            Driver.Current.FindElement(Locators.SignIn.RegistrationButton).Click();
            return this;
        }

        public SignInPage ClickForgotPasswordButton()
        {

            Driver.Current.FindElement(Locators.SignIn.ForgotPasswordButton).Click();
            return this;
        }
    }
}

using OpenQA.Selenium;

namespace ConsoleApp1.ForgotPassword
{
    public class ForgotPasswordPage
    {
        protected IWebDriver driver;
        public ForgotPasswordPage(IWebDriver driver)
        {

        }
        public ForgotPasswordPage ClickForgotPasswordLink()
        {
            driver.FindElement(Locators.forgotPasswordLink).Click();
            return new ForgotPasswordPage(driver);
        }
        public ForgotPasswordPage ClickSendButton(string email)
        {
            driver.FindElement(Locators.emailField).SendKeys(email);
            driver.FindElement(Locators.sendButton).Click();
            return this;
        }
        public ForgotPasswordPage ClickCrossButton()
        {
            driver.FindElement(Locators.crossButton).Click();
            return this;
        }
        /*public ForgotPasswordPage ClickBackButton()
        {
            driver.FindElement(new Locators().backButton).Click();
            return new AuthPage(driver);
        }*/
    }
}

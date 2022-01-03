using OpenQA.Selenium;

namespace ConsoleApp1.ForgotPassword
{
    class ForgotPasswordPage
    {
        protected IWebDriver driver;
        public ForgotPasswordPage(IWebDriver driver)
        {

        }
        public ForgotPasswordPage ClickForgotPasswordLink()
        {
            driver.FindElement(new Locators().forgotPasswordLink).Click();
            return new ForgotPasswordPage(driver);
        }
        public ForgotPasswordPage ClickSendButton(string email)
        {
            driver.FindElement(new Locators().emailField).SendKeys(email);
            driver.FindElement(new Locators().sendButton).Click();
            return this;
        }
        public ForgotPasswordPage ClickCrossButton()
        {
            driver.FindElement(new Locators().crossButton).Click();
            return this;
        }
        /*public ForgotPasswordPage ClickBackButton()
        {
            driver.FindElement(new Locators().backButton).Click();
            return new AuthPage(driver);
        }*/
    }
}

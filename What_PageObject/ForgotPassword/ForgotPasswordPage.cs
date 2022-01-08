using OpenQA.Selenium;

namespace What_PageObject.ForgotPassword
{
    public class ForgotPasswordPage
    {
        protected IWebDriver driver;
        public ForgotPasswordPage(IWebDriver driver)
        {
            this.driver = driver;
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
        public ForgotPasswordPage ClickBackButton()
        {
            driver.FindElement(Locators.backButton).Click();
            return this;
        }
    }
}

using OpenQA.Selenium;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.ForgotPassword
{
    public class ForgotPasswordPage : BasePage
    {
        IWebDriver driver;
        public ForgotPasswordPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public ForgotPasswordPage ClickForgotPasswordLink()
        {
            ClickElement(Locators.ForgotPassword.forgotPasswordLink);
            return this;
        }
        public ForgotPasswordPage ClickForgotPasswordLabel()
        {
            ClickElement(Locators.ForgotPassword.forgotPasswordLabel);
            return this;
        }
        public ForgotPasswordPage FillEmailField(string email)
        {
            FillField(Locators.ForgotPassword.emailAddressField, email);
            return this;
        }
        public ForgotPasswordPage ClickSendButton()
        {
            ClickElement(Locators.ForgotPassword.sendButton);
            return this;
        }
        public ForgotPasswordPage ClickCrossButton()
        {
            ClickElement(Locators.ForgotPassword.xButton);
            return this;
        }
        public SignInPage.SignInPage ClickBackButton()
        {
            ClickElement(Locators.ForgotPassword.backButton);
            return new SignInPage.SignInPage();
        }
        public string GetTextValue(By locator)
        {
            return Driver.Current.FindElement(locator).Text;
        }
    }
}

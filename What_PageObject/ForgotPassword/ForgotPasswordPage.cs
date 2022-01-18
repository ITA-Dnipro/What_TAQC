using System;
using What_Common.DriverManager;
using What_Common.Resources;
using OpenQA.Selenium;
using What_PageObject.SignInPage;
using NUnit.Framework;

namespace What_PageObject.ForgotPassword
{
    public class ForgotPasswordPage : BasePage
    {
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
        public ForgotPasswordPage VerifyTextValueInModalWindow()
        {
            string expexted = Resources.ForgotPassword.modalWindowText;
            string acrual = GetTextValue(Locators.ForgotPassword.modalWindowText);
            Assert.AreEqual(expexted, acrual);
            return this;
        }
    }
}

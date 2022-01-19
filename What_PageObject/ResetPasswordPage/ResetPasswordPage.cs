using What_PageObject;
using What_Common.Resources;
using What_Common.DriverManager; 
using NUnit.Framework;
using OpenQA.Selenium;

namespace ResetPassword
{
    public class ResetPasswordPage : BasePage
    {
        public ResetPasswordPage FillEmail(string email)
        {
            FillField(Locators.ResetPassword.emailAddressField, email);
            LooseFocusFromInput();
            return this;
        }
        public ResetPasswordPage VerifyEmailFilled(string expected)
        {

            string actual = Driver.Current.FindElement(Locators.ResetPassword.emailAddressField).GetAttribute("value");
            Assert.AreEqual(expected, actual);
            return this;
        }
        public ResetPasswordPage FillNewPassword(string password)
        {
            FillField(Locators.ResetPassword.newPasswordField, password);
            LooseFocusFromInput();
            return this;
        }
        public ResetPasswordPage VerifyNewPasswordFilled(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.ResetPassword.newPasswordField).GetAttribute("value");
            Assert.AreEqual(expected, actual);
            return this;
        }
        public ResetPasswordPage FillConfirmPassword(string password)
        {
            FillField(Locators.ResetPassword.confirmPasswordField, password);
            LooseFocusFromInput();
            return this;
        }

        public ResetPasswordPage VerifyConfirmPasswordFilled(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.ResetPassword.confirmPasswordField).GetAttribute("value");
            Assert.AreEqual(expected, actual);
            return this;
        }
        public ResetPasswordPage ClickConfirmButton()
        {
            ClickElement(Locators.ResetPassword.confirmButton);
            return this;
        }
        public ResetPasswordPage VerifyConfirmButtonIsEnable()
        {
            bool actual = Driver.Current.FindElement(Locators.ResetPassword.confirmButton).Enabled;
            Assert.IsTrue(actual);
            return this;
        }
        public ResetPasswordPage VerifyConfirmButtonIsDisable()
        {
            bool actual = Driver.Current.FindElement(Locators.ResetPassword.confirmButton).Enabled;
            Assert.IsFalse(actual);
            return this;
        }
        public ResetPasswordPage ClickBackButton() 
        {
            ClickElement(Locators.ResetPassword.backButton);
            return this;
        }
        public ResetPasswordPage VerifyEmailError(string expected)
        {
            Assert.AreEqual(expected, Driver.Current.FindElement(Locators.ResetPassword.emailAddressError).Text);
            return this;
        }
        public ResetPasswordPage VerifyNewPasswordError(string expected)
        {
            Assert.AreEqual(expected, Driver.Current.FindElement(Locators.ResetPassword.newPasswordError).Text);
            return this;
        }
        public ResetPasswordPage VerifyConfirmPasswordError(string expected)
        {
            Assert.AreEqual(expected, Driver.Current.FindElement(Locators.ResetPassword.confirmPasswordError).Text);
            return this;
        }
        private void LooseFocusFromInput()
        {
            ClickElement(Locators.ResetPassword.pageLabel);
        }
        public void VerifyRedirectToAuthPage()
        {
            string expectedUrl = Resources.WhatUrl + "auth"; 
            Assert.AreEqual(expectedUrl, Driver.Current.Url);
        }
    }
}
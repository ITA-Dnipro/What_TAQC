using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using What_PageObject.ForgotPassword;
using What_Common.Resources;
using What_Common.DataProvider;
using What_Common.DriverManager;

namespace What_UITest
{
    public class VerifyThatPasswordResetRequestCanWasSend : BaseTest.BaseTest
    {

        [SetUp]
        public void Setup()
        {

        }

        [Test(Description = "")]
        [TestCase(Resources.ForgotPassword.modalWindowText)]
        public void VerifyThatPasswordResetRequestCanWasSend_ValidValues(string expected)
        {
            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
            ForgotPasswordPage forgotPassword = new ForgotPasswordPage(Driver.Current);
            forgotPassword.ClickForgotPasswordLink()
                .FillEmailField(admin.Email)
                .ClickSendButton();
            Assert.AreEqual(expected, forgotPassword.GetTextValue(Locators.ForgotPassword.modalWindowText));
        }

        [Test(Description = "")]
        [TestCase(Resources.ForgotPassword.invalidEmail, Resources.ForgotPassword.invalidEmailError)]
        public void VerifyThatPasswordResetRequestCanWasSend_InvalidValuesEmail(string email, string expected)
        {
            ForgotPasswordPage forgotPassword = new ForgotPasswordPage(Driver.Current);
            forgotPassword.ClickForgotPasswordLink()
                .FillEmailField(email)
                .ClickForgotPasswordLabel()
                .ClickSendButton();
            Assert.AreEqual(expected, forgotPassword.GetTextValue(Locators.ForgotPassword.emailAddressError));
        }

        [Test(Description = "")]
        [TestCase(Resources.ForgotPassword.invalidEmail, Resources.ForgotPassword.emptyEmailError)]
        public void VerifyThatPasswordResetRequestCanWasSend_EmptyValuesEmail(string email, string expected)
        {
            ForgotPasswordPage forgotPassword = new ForgotPasswordPage(Driver.Current);
            forgotPassword.ClickForgotPasswordLink()
                .FillEmailField("")
                .ClickForgotPasswordLabel()
                .ClickSendButton();
            Assert.AreEqual(expected, forgotPassword.GetTextValue(Locators.ForgotPassword.emailAddressError));
        }

        [Test(Description = "")]
        [TestCase(Resources.ForgotPassword.doesntExistEmail)]
        public void VerifyThatPasswordResetRequestCanWasSend_DoesntExistValues(string email)
        {
            ForgotPasswordPage forgotPassword = new ForgotPasswordPage(Driver.Current);
            forgotPassword.ClickForgotPasswordLink()
                .FillEmailField(email)
                .ClickSendButton();
            Assert.AreEqual(Resources.ForgotPassword.DoesntExistEmailError(Resources.ForgotPassword.doesntExistEmail), forgotPassword.GetTextValue(Locators.ForgotPassword.sendButtonError));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Current.Close();
        }
    }
}
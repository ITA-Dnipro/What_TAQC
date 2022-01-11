using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.SignInPage
{
    public class Locators
    {
        #region ElementLocators

        public static readonly By SignInButton = By.XPath("//*[@class='btn button__default___3hOmG button__button___24ZfP auth__form-button___3KEpa']");
        public static readonly By EmailField = By.XPath("//*[@id='email']");
        public static readonly By PasswordField = By.XPath("//*[@id='password']");

        public const string RegistrationButton = "//*[contains(text(),'Registration')]";
        public const string ForgotPasswordButton = "//*[contains(text(),'Forgot Password?')]";
        #endregion

        #region ExpectedResultLocators
        public const string logInAsAdminExpectedResult = "//*[contains(text(),'Add a student')]";
        public const string logInAsSecretaryExpectedResult = "//*[contains(text(),'Add a mentor')]";
        public const string logInAsMentorExpectedResult = "//*[contains(text(),'Add a lesson')]";
        public const string logInAsStudentExpectedResult = "//*[@class='custom-control-label list-of-courses__custom-control-label___3hlig']";
        public const string registrationButtonExpectedResult = "//*[@class='btn button__default___3hOmG button__button___24ZfP btn btn-block btn-info']";
        public const string forgotPasswordButtonExpectedResult = "//*[contains(text(),'Forgot your password?')]";
        #endregion
    }
}

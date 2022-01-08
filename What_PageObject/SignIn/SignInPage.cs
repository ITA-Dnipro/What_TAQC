using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.SignIn
{
    public class SignInPage
    {
        public static readonly By signInButton = By.XPath(Locators.SignInButton);
        public static readonly By emailField = By.XPath(Locators.EmailField);
        public static readonly By passwordField = By.XPath(Locators.PasswordField);
        public static readonly By registrationButton = By.XPath(Locators.RegistrationButton);
        public static readonly By forgotPasswordButton = By.XPath(Locators.ForgotPasswordButton);

        DriverManager.Driver Driver = new DriverManager.Driver();
        private IWebElement signInButtonWebElement => DriverManager.Driver.Current.FindElement(By.XPath("//*[@class='btn button__default___3hOmG button__button___24ZfP auth__form-button___3KEpa']"));


    }
}

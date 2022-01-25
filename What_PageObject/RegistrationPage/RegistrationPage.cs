using NUnit.Framework;
using OpenQA.Selenium;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.RegistrationPage
{
    public class RegistrationPage : BasePage
    {
        public RegistrationPage FillFirstName(string firstName)
        {
            FillField(Locators.RegistrationPage.FirstNameField, firstName);
            return this;
        }
        public RegistrationPage FillLastName(string lastName)
        {
            FillField(Locators.RegistrationPage.LastNameField, lastName);
            return this;
        }
        public RegistrationPage FillEmailAdress(string email)
        {
            FillField(Locators.RegistrationPage.EmailAdressField, email);
            return this;
        }
        public RegistrationPage FillPassword(string password)
        {
            FillField(Locators.RegistrationPage.PasswordField, password);
            return this;
        }
        public RegistrationPage FillConfirmPassword(string password)
        {
            FillField(Locators.RegistrationPage.ConfirmPasswordField, password);
            return this;
        }
        public RegistrationPage VerifyFirstNameFilled(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.RegistrationPage.FirstNameField).GetAttribute("value");
            Assert.AreEqual(expected, actual);
            return this;
        }
        public RegistrationPage VerifyLastNameFilled(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.RegistrationPage.LastNameField).GetAttribute("value");
            Assert.AreEqual(expected, actual);
            return this;
        }
        public RegistrationPage VerifyEmailAdressFilled(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.RegistrationPage.EmailAdressField).GetAttribute("value");
            Assert.AreEqual(expected, actual);
            return this;
        }
        public RegistrationPage VerifyPasswordFilled(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.RegistrationPage.PasswordField).GetAttribute("value");
            Assert.AreEqual(expected, actual);
            return this;
        }
        public RegistrationPage VerifyConfirmPasswordFilled(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.RegistrationPage.ConfirmPasswordField).GetAttribute("value");
            Assert.AreEqual(expected, actual);
            return this;
        }
        public RegistrationPage VerifyErrorMassage(string expectedMassage)
        {
            string actualMassage = Driver.Current.FindElement(Locators.RegistrationPage.ErrorField).Text;
            Assert.AreEqual(expectedMassage, actualMassage);
            return this;
        }
        public RegistrationPage ClickSignUpButton(By signUpButton)
        {
            ClickElement(signUpButton);
            return this;
        }
        public RegistrationPage ClickRegistrationButton(By registrationButton)
        {
            ClickElement(registrationButton);
            return this;
        }
        public RegistrationPage VerifyRegistration()
        {
            var window = wait.Until(e => e.FindElement(Locators.RegistrationPage.NamePageRegistration));
            var IslModalWindow = window.Displayed;
            Assert.IsTrue(IslModalWindow);
            return this;
        }               
    }
}

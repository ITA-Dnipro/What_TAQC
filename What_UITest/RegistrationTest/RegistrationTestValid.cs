using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject;
using What_PageObject.RegistrationPage;

namespace What_UITest.RegistrationTest
{
    internal class RegistrationTestValid : BaseTest
    {
        private RegistrationPage registrationPage;
        [SetUp]
        public void Setup()
        {
            registrationPage = new RegistrationPage()
                 .ClickRegistrationButton(Locators.RegistrationPage.Registration);
        }

        [Test]
        public void UnnasignedUserCanRegister()
        {
            registrationPage.FillFirstName(Resources.firstName)
            .VerifyFirstNameFilled(Resources.firstName)
            .FillLastName(Resources.lastName)
            .VerifyLastNameFilled(Resources.lastName)
            .FillEmailAdress(Resources.Email)
            .VerifyEmailAdressFilled(Resources.Email)
            .FillPassword(Resources.Password)
            .VerifyPasswordFilled(Resources.Password)
            .FillConfirmPassword(Resources.Password)
            .VerifyConfirmPasswordFilled(Resources.Password)
            .ClickSignUpButton(Locators.RegistrationPage.SignUpButton)
            .VerifyRegistration();
        }

    }
}
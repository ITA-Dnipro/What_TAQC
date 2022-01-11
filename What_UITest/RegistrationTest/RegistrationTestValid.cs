using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using What_Common.DriverManager;
using What_PageObject.BasePage;
using What_PageObject.RegistrationPage;

namespace What_UITest.RegistrationTest
{
    internal class RegistrationTestValid : BaseTest.BaseTest
    {
        public void Setup()
        {
            basePage.ClickElement(Locators.Registration);
            
        }

        [Test]
        public void UnnasignedUserCanRegister()
        {
            registrationPage.EnterFirstName(Resources.firstName)
            .EnterLastName(Resources.lastName)
            .EnterEmailAdress(Resources.Email)
            .EnterPassword(Resources.Password)
            .EnterConfirmPassword(Resources.Password);
            basePage.ClickElement(Locators.ButtonSignUp);
            var wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10))
                        .Until(driver => driver.FindElement(Locators.NameModalWindowPageRegistration));
            var IslModalWindow = wait.Displayed;
            Assert.IsTrue(IslModalWindow);
        }

    }
}
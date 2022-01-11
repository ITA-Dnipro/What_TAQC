using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;
using What_PageObject.RegistrationPage;

namespace What_UITest.RegistrationTest
{
    internal class RegistrationTestInvalid : BaseTest.BaseTest
    {
        public void Setup()
        {
            basePage.ClickElement(Locators.Registration);

        }

        [Test]
        public void UnnasignedUserCantRegister()
        {
            registrationPage.EnterFirstName(Resources.empty)
            .EnterLastName(Resources.empty)
            .EnterEmailAdress(Resources.empty)
            .EnterPassword(Resources.empty)
            .EnterConfirmPassword(Resources.empty);
            basePage.ClickElement(Locators.ButtonSignUp);
            var IslModalWindow = "";
            Assert.AreEqual(Resources.ErrorFieldName, IslModalWindow);
        }
    }
}

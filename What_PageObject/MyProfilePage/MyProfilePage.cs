using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using What_Common.Resources;
using What_PageObject.ChangePassword;
using What_Common.DriverManager;
using NUnit.Framework;

namespace What_PageObject.MyProfile
{
    public class MyProfilePage : BasePage
    {

        private Waiter waiter;

        private string FirstName { get;}

        private string LastName { get;}

        private string EmailAddress { get;}

        public MyProfilePage()
        {
            this.waiter = new Waiter(Driver.Current);
            FirstName = Driver.Current.FindElement(Locators.MyProfilePage.FirstNameField).Text;
            LastName = Driver.Current.FindElement(Locators.MyProfilePage.LastNameField).Text;
            EmailAddress = Driver.Current.FindElement(Locators.MyProfilePage.EmailAddressField).Text;
        }


        /// <summary>
        /// Click on 'change password' button
        /// </summary>
        public ChangePasswordPage ChangePasswordClick()
        {
            ClickElement(Locators.MyProfilePage.ChangePasswordButton);
            waiter.wait.Until(ExpectedConditions.UrlMatches(Resources.WhatChangePasswordUrl));
            return new ChangePasswordPage();
        }


        /// <summary>
        /// Verify That name of user and his info in this panel equals
        /// </summary>
        /// <param name="expectedName">Expected params</param>
        /// <returns></returns>
        public MyProfilePage VerifyThatInfoAboutUserIsCorrect(string expectedName, string expectedLastName, string expectedEmail)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedName, FirstName);
                Assert.AreEqual(expectedLastName, LastName);
                Assert.AreEqual(expectedEmail, EmailAddress);
            });
            
            return this;
        }

        public ChangePasswordPage VerifyThatChangePasswordWorked()
        {
            ChangePasswordClick();
            string expected = Resources.WhatChangePasswordUrl;
            string actual = Driver.Current.Url;
            Assert.AreEqual(expected, actual);
            return new ChangePasswordPage();
        }


    }
}
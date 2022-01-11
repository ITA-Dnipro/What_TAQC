using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using What_Common.DriverManager;
using What_PageObject.SignInPage;

namespace What_UITest.SignInTests
{
    public class LogInTest
    {
        string email = "james.smith@example.com";
        string password = "Nj_PJ7K9";

        [SetUp]
        public void Setup()
        {
            Driver.MaximizeWindow();
            Driver.GoToUrl();
        }

        [Test]
        [TestCase("http://localhost:8080/students")]
        public void LogInAsTest(string expectedUrl)
        {
            var LogInPage = new SignInPageObject(Driver.Current);
            Assert.Multiple(() =>
            {
                Assert.True(LogInPage.atPage());
                LogInPage.LogIn(email, password, expectedUrl);
                Assert.AreEqual(expectedUrl, Driver.Current.Url);
            });
        }

        [Test]
        [TestCase("http://localhost:8080/students")]
        public void LogInAsAdminValidTest(string expectedUrl)
        {
            var LogInPage = new SignInPageObject(Driver.Current);

            Assert.True(LogInPage.atPage());

            LogInPage
                .EnterEmail(email)
                .EnterPassword(password)
                .ClickSignInButton(expectedUrl);

            string actualUrl = Driver.Current.Url;
            Assert.AreEqual(expectedUrl, actualUrl);
        }



    }
}

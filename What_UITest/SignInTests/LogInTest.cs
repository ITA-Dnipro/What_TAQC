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
            Driver.Current.Manage().Window.Maximize();
            Driver.Current.Navigate().GoToUrl("http://localhost:8080/auth");
        }

        [Test]
        public void LogInAsTest()
        {
            var LogInPage = new SignInPageObject(Driver.Current);

            Assert.True(LogInPage.atPage());

            LogInPage
                .LogIn(email, password);

            string actualUrl = Driver.Current.Url;
            string expectedUrl = "http://localhost:8080/students";

            //waiter here

            Assert.AreEqual(expectedUrl, actualUrl);
        }

        [Test]
        public void LogInAsAdminValidTest()
        {
            var LogInPage = new SignInPageObject(Driver.Current);

            Assert.True(LogInPage.atPage());

            LogInPage
                .EnterEmail(email)
                .EnterPassword(password)
                .ClickSIgnInButton();

            string actualUrl = Driver.Current.Url;
            string expectedUrl = "http://localhost:8080/students";

            //waiter here

            Assert.AreEqual(expectedUrl, actualUrl);
        }



    }
}

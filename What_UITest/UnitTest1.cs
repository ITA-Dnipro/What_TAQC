using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ConsoleApp1.ForgotPassword;
using System.Threading;

namespace What_UITest
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://localhost:8080/auth");
        }

        [Test]
        [TestCase("thomas.roberts@example.com", @"http://localhost:8080/forgot-password")]
        public void ForgotPasswordAndCross(string email, string expected)
        {
            ForgotPasswordPage forgotPassword = new ForgotPasswordPage(driver);
            forgotPassword.ClickForgotPasswordLink();
            forgotPassword.ClickSendButton(email);
            Thread.Sleep(1500);
            forgotPassword.ClickCrossButton();
            Assert.AreEqual(expected, driver.Url);
        }

        [Test]
        [TestCase("thomas.roberts@example.com", @"http://localhost:8080/auth")]
        public void ForgotPasswordAndBack(string email, string expected)
        {
            ForgotPasswordPage forgotPassword = new ForgotPasswordPage(driver);
            forgotPassword.ClickForgotPasswordLink();
            forgotPassword.ClickSendButton(email);
            Thread.Sleep(1500);
            forgotPassword.ClickBackButton();
            Assert.AreEqual(expected, driver.Url);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
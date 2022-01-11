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
        private WebDriver? driver;

        string email = "james.smith@example.com";
        string password = "Nj_PJ7K9";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:8080/auth");
        }

        [Test]
        public void LogInValid()
        {
            var LogInPage = new SignInPageObject(driver);
            LogInPage
                .LogIn(email,password);

            By actual = By.XPath("//*[contains(text(),'Add a student')]");
            By expected = By.XPath("//*[contains(text(),'Add a student')]");
            Thread.Sleep(1000);

            Assert.AreEqual(actual,expected);
        }

    }
}

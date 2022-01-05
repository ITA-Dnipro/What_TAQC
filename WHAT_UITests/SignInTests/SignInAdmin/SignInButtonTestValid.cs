using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_PageObject.SignIn;
using What_PageObject.DriverManager;

namespace WHAT_UITests.SignInTests.SignInAdmin
{
    public class SignInButtonTestValid
    {
        private ChromeDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:8080/auth");
        }

        [Test]
        public void SetEmailField()
        {
            driver.FindElement(SignInPage.signInButton).Click();
            By expected = By.XPath("//*[contains(text(),'Add a student')]");
            By actual = By.XPath("//*[contains(text(),'Add a student')]");
            Assert.AreEqual(expected, actual);
        }
    }
}

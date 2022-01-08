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
    public class EmailFieldTestValid
    {
        [SetUp]
        public void Setup()
        {
            Driver.Current.Manage().Window.Maximize();
            Driver.Current.Navigate().GoToUrl("http://localhost:8080/auth");
        }

        [Test]
        public void SetEmailField()               //checkField?
        {
            Driver.Current.FindElement(SignInPage.emailField).SendKeys("james.smith@example.com");    //namesShorter(Driver)
            By expected = By.XPath("//*[contains(text(),'Add a student')]");
            By actual = By.XPath("//*[contains(text(),'Add a student')]");
            Assert.AreEqual(expected, actual);
        }
    }
}

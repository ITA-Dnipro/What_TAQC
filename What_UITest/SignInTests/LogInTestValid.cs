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
using What_PageObject.StudentsPage;
using What_Common.Resources;

namespace What_UITest.SignInTests
{
    public class LogInTestValid : BaseTest
    {
        string email = "james.smith@example.com";
        string password = "Nj_PJ7K9";

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void LogInValid()
        {
            var SignInPage = new SignInPage();
            SignInPage.IsAtPage();
            SignInPage.EnterEmail("james.smith@example.com");
            SignInPage.EnterPassword("Nj_PJ7K9");
            SignInPage.ClickSignInButton();

            SignInPage.WaitUntilElementLoads<StudentsPage>(Locators.Students.ListTable);

            string actual = Driver.Current.Url;
            string expected = "http://localhost:8080/students";

            Assert.AreEqual(actual, expected);
        }

    }
}

//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using What_Common.DriverManager;
//using What_PageObject.SignInPage;

//namespace What_UITest.SignInTests
//{
//    public class LogInTestValid
//    {
//        string email = "james.smith@example.com";
//        string password = "Nj_PJ7K9";

//        [SetUp]
//        public void Setup()
//        {

//            Driver.Current.Manage().Window.Maximize();
//            Driver.Current.Navigate().GoToUrl("http://localhost:8080/auth");
//        }

//        [Test]
//        public void LogInValid()
//        {
//            var SignInPage = new SignInPage(Driver.Current);
//            SignInPage.IsAtPage();
//            SignInPage.EnterEmail("EMAIL");
//            SignInPage.EnterPassword("PASS");
//            SignInPage.ClickSignInButton("http://localhost:8080/students");

//            string actual = Driver.Current.Url;
//            string expected = "http://localhost:8080/students";
//            //By expected = By.XPath("//*[contains(text(),'Add a student')]");

//            Assert.AreEqual(actual, expected);
//        }

//    }
//}

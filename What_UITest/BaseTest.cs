using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.BasePage;
using What_PageObject.RegistrationPage;
using Resources = What_Common.Resources.Resources;

namespace What_UITest.BaseTest

{
    internal class BaseTest
    {
        protected BasePage basePage;
        protected RegistrationPage registrationPage;
        [SetUp]
        public void Setup()
        {
            Driver.Current.Manage().Window.Maximize();
            Driver.Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Current.Navigate().GoToUrl(Resources.url);
            registrationPage = new RegistrationPage();
            basePage = new BasePage();
        }
        [TearDown]
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Failure))
            {
                string fileName = $"{TestContext.CurrentContext.Test.Name}";
                FileInfo screenshotPath = new FileInfo($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\screenshot\\{fileName}.png");
                Directory.CreateDirectory(screenshotPath.DirectoryName);

                ITakesScreenshot takeScreenshot = (ITakesScreenshot)Driver.Current;
                Screenshot screenshot = takeScreenshot.GetScreenshot();
                screenshot.SaveAsFile(screenshotPath.FullName, ScreenshotImageFormat.Png);
            }

            Driver.Current?.Quit();
        }
    }
}


    



    
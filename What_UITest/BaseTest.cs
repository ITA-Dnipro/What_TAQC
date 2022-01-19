using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;
using What_Common.DriverManager;

namespace What_UITest
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Current = null;
            Driver.MaximizeWindow();
            Driver.ImplicitWait();
            Driver.GoToUrl();
            //Driver.Current.Manage().Window.Maximize();
            //Driver.Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Driver.Current.Navigate().GoToUrl("http://localhost:8080");
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
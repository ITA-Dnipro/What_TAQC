using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_UITest.BaseTest

{
    internal class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.GoToUrl();
            Driver.Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.MaximizeWindow();
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

   
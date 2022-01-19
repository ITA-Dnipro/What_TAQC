using NLog;
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
        Logger log = LogManager.GetCurrentClassLogger();

        [SetUp]
        public void Setup()
        {
            Driver.Current = null;
            Driver.MaximizeWindow();
            Driver.ImplicitWait();
            Driver.GoToUrl();
            log.Info("Start Test");
        }

        [TearDown]
        public void AfterTest()
        {
            var context = TestContext.CurrentContext;
            var testName = context.Test.FullName;

            log.Info($"{testName} - {context.Result.Outcome.Status}");


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
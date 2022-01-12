using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using What_PageObject.ChangePassword;

namespace What_UITest
{
    public class ChangePassword_ValidValues : BaseTest
    {
        private const string PasswordNew = "765Rt##asd4";
        private const string PasswordOld = "765Rt##asd";
        private IWebDriver driver;
        private ChangePasswordPage page;

        [SetUp]


        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://localhost:8080/");

            page = new ChangePasswordPage();


        }


        [Test]
        public void ChangePasswordAsSecretary()
        {
        }

        [TearDown]

        public void Aftertest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Failure))
            {
                string fileName = $"{TestContext.CurrentContext.Test.Name}";
                FileInfo screenshotPath = new FileInfo($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\screenshot\\{fileName}.png");
                Directory.CreateDirectory(screenshotPath.DirectoryName);

                ITakesScreenshot takeScreenshot = (ITakesScreenshot)driver;
                Screenshot screenshot = takeScreenshot.GetScreenshot();
                screenshot.SaveAsFile(screenshotPath.FullName, ScreenshotImageFormat.Png);
            }

            driver?.Quit();
        }
    }
}
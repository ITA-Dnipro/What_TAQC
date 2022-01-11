using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using What_PageObject.ChangePassword;
using What_UITest.ChangePasswordTests;

namespace What_UITest
{
    public class ChangePassword_ValidValues
    {
        private const string PasswordNew = "765Rt##asd4";
        private const string PasswordOld = "765Rt##asd";
        Login login;

        IWebDriver driver;

        ChangePasswordPage page;

        [SetUp]


        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("http://localhost:8080/");

            login = new Login(driver);
            page = new ChangePasswordPage(driver);


        }


        public void LoginAsSecretary(string email, string password)
        {
            login.FillEmail(email);
            login.FillPassword(password);
            login.ClickLoginButton();
        }

        [Test]
        public void ChangePasswordAsSecretary()
        {
            LoginAsSecretary("Adrian@secretar.com", PasswordNew);
            page.ClickDropDownMenu();
            page.ClickChangePasswordButton();
            page.FillCurrentPasswordField(PasswordOld)
                 .FillNewPasswordField(PasswordNew)
                 .FillConfirmNewPasswordField(PasswordNew)
                 .ClickSaveButton();

            Thread.Sleep(1000);
            page.ClickConfirmButtonInModalWindow();

            Thread.Sleep(1000);

            //page.Logout();


            Thread.Sleep(1000);

            LoginAsSecretary("Adrian@secretar.com", PasswordNew);

            Assert.AreEqual("http://localhost:8080/mentors", driver.Url);


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
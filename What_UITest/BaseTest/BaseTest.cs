using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_UITest.BaseTest
{
    internal class BaseTest
    {
        public void Setup()
        {
            DriverManager.Current = null;
            DriverManager.Current.Manage().Window.Maximize();
            DriverManager.Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            DriverManager.Current.Navigate().GoToUrl("http://localhost:8080/");

        }



        
        public void AfterTest()
        {
            if (TestContext.CurrentContext.Result.Outcome.Equals(ResultState.Failure))
            {
                string fileName = $"{TestContext.CurrentContext.Test.Name}";
                FileInfo screenshotPath = new FileInfo($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\screenshot\\{fileName}.png");
                Directory.CreateDirectory(screenshotPath.DirectoryName);

                ITakesScreenshot takeScreenshot = (ITakesScreenshot)DriverManager.Current;
                Screenshot screenshot = takeScreenshot.GetScreenshot();
                screenshot.SaveAsFile(screenshotPath.FullName, ScreenshotImageFormat.Png);
            }

            DriverManager.Current?.Quit();
        }
    }
}

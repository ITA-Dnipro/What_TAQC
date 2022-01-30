using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace What_Common.DriverManager
{
    public class Driver
    {
        const string url = "http://localhost:8080/";
        public Driver() { }

        private static IWebDriver? driver;

        public static IWebDriver Current
        {
            get
            {
                if (driver == null)
                {
                    driver = new ChromeDriver();
                }
                return driver;
            }
        }

        public static void GoToUrl()
        {
            Current.Navigate().GoToUrl("http://localhost:8080/auth");
        }

        public static void MaximizeWindow()
        {
            Current.Manage().Window.Maximize();
        }
    }
}

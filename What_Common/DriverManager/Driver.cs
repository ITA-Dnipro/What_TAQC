using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_Common.DriverManager
{
    public class Driver
    {
        public const string url = "http://localhost:8080/";
        public Driver()
        {

        }

        private static IWebDriver driver;

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
            Current.Navigate().GoToUrl("http://localhost:8080/");
        }

        public static void MaximizeWindow()
        {
            Current.Manage().Window.Maximize();
        }

    }
}

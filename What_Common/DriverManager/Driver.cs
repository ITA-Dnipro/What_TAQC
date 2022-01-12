using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace What_Common.DriverManager
{
    public class Driver
    {
        public Driver()
        {

        }

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
            set { driver = value; }
        }
    }
}

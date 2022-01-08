using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Mentor
{
    public class TestsWHAT
    {
        private By Registration = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/div[4]/div[2]/p/a");
        private By NamePageRegistration = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/h3");
        private By FieldFirstName = By.XPath("//*[@id=\"firstName\"]");
        private By FieldLastName = By.XPath("//*[@id=\"lastName\"]");
        private IWebDriver driver;
        string namePageRegistration;
        string expectedNamePageRegistration = "Sign up to WHAT";
        string firstName = "Qwerty";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:8080/auth");
            driver.FindElement(Registration).Click();
            namePageRegistration = driver.FindElement(NamePageRegistration).Text;
            Assert.AreEqual(expectedNamePageRegistration, namePageRegistration);
        }

        [Test]
        public void Test1()
        {
            driver.FindElement(FieldFirstName).SendKeys(firstName);
            string actualFirstName = driver.FindElement(FieldFirstName).GetAttribute("value");
            Assert.AreEqual(firstName, actualFirstName);
        }
    }

}
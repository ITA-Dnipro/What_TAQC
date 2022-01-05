using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace What_UITest
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(@"http://localhost:8080/forgot-password");
        }

        [Test]
        [TestCase("thomas.roberts@example.com", @"http://localhost:8080/auth")]
        public void Test1(string email, string expected)
        {
            ForgotPassword forgotPassword = new ForgotPassword(driver);
            driver.FindElement(Locators.forgotPasswordLink).Click();
            driver.FindElement(Locators.emailField).SendKeys(email);
            driver.FindElement(Locators.sendButton).Click();
            driver.FindElement(Locators.crossButton).Click();
            Assert.AreEqual(expected, driver.Url);
        }

        [TearDown]
        public void TearDown()
        {
            driver.
        }
    }
}
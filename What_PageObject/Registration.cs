namespace What_PageObject
{
    public class Registration
    {
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


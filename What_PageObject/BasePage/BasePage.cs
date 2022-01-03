using OpenQA.Selenium;

namespace What_PageObject.BasePage
{
    public class BasePage
    {
        IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickElement(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public void FillField(By locator, string text)
        {
            var field = driver.FindElement(locator);
            field.Click();
            field.SendKeys(text);
        }
    }
}

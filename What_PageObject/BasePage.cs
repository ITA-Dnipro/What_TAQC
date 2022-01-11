using OpenQA.Selenium;

namespace PageObject
{
    public abstract class BasePage
    {
        protected IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        protected void FillField(By locator, string text)
        {
            var field = driver.FindElement(locator);
            field.Click();
            //field.Clear(); //??
            field.SendKeys(Keys.Control + "a");
            field.SendKeys(Keys.Delete);
            field.SendKeys(text);
        }
        protected void ClickItem(By locator)
        {
            driver.FindElement(locator).Click();
        }
    }
}
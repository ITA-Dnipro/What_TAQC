using OpenQA.Selenium;
using What_Common.DriverManager;

namespace What_PageObject
{
    public abstract class BasePage
    {
        public void ClickElement(By locator)
        {
            Driver.Current.FindElement(locator).Click();
        }

        public void FillField(By locator, string text)
        {
            var field = Driver.Current.FindElement(locator);
            field.SendKeys(Keys.Control + "a");
            field.SendKeys(Keys.Delete);
            field.SendKeys(text);
        }
    }
}

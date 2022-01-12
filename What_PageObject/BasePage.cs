using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using What_Common.DriverManager;

namespace What_PageObject
{
    public abstract class BasePage
    {
        protected WebDriverWait wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));

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

        public T WaitUntilElementLoads<T>(By locator) where T : BasePage
        {
            wait.Until(e => e.FindElement(locator));
            return GetPageInstance<T>(Driver.Current);
        }

        protected T GetPageInstance<T>(params object[] args) where T : BasePage
        {
            T foundPage = null;
            foundPage = (T)Activator.CreateInstance(typeof(T));

            return foundPage;
        }
    }
}
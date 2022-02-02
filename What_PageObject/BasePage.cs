using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject
{
    public abstract class BasePage
    {
        protected WebDriverWait wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));
        List<BasePage> pages = new List<BasePage>();
       
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

        public void Logout()
        {
            Driver.Current.FindElement(Locators.NavBar.DropDownNameElement).Click();
            Driver.Current.FindElement(Locators.NavBar.LogOutLink).Click();
        }

        public T WaitUntilElementLoads<T>(By locator) where T : BasePage
        {
            wait.Until(e => e.FindElement(locator));
            return GetPageInstance<T>();
        }

        protected T GetPageInstance<T>() where T : BasePage
        {
            T? foundPage = null;
            foreach (BasePage page in pages)
            {
                if (page is T)
                {
                    foundPage = (T)page;
                    break;
                }
            }
            if (foundPage == null)
            {
                foundPage = (T)Activator.CreateInstance(typeof(T));
            }

            return foundPage;
        }
    }
}
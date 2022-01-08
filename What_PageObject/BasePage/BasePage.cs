using OpenQA.Selenium;
using What_PageObject.UnassignedUsers;

namespace What_PageObject.BasePage
{
    public abstract class BasePage
    {
        public void ClickElement(By locator)
        {
            DriverManager.DriverManager.Current.FindElement(locator).Click();
        }

        public void FillField(By locator, string text)
        {
            var field = DriverManager.DriverManager.Current.FindElement(locator);
            field.SendKeys(Keys.Control + "a");
            field.SendKeys(Keys.Delete);
            field.SendKeys(text);
        }

        public void Logout()
        {
            ClickElement(Locators.TopDropdownMenuButton);
            ClickElement(Locators.TopDropdownLogoutButton);
        }
    }
}

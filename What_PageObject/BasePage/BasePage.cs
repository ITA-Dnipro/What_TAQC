using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.ChangePassword
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

        public void Logout()
        {
            ClickElement(Locators.TopDropdownMenuButton);
            ClickElement(Locators.TopDropdownLogoutButton);
        }
    }
}

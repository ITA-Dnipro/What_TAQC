using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest1
{
    public class MyProfilePage : BasePage
    {
        private IWebElement elem_change_password_button => driver.FindElement(By.XPath(Locators.MyProfilePage.CHANGE_PWD_BTN));

        public MyProfilePage(IWebDriver driver) : base(driver)
        {

        }

        public void ChangePasswordClick()
        {
            elem_change_password_button.Click();
            System.Threading.Thread.Sleep(1000);
        }
    }
}

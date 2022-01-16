using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace What_PageObject.Secretaries
{
    public class AddSecretaryPage : BasePage
    {
        protected IWebDriver driver;
        public AddSecretaryPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}

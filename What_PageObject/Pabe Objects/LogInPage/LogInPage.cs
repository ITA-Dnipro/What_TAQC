using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SeleniumTest1
{
    public class LogInPage : BasePage
    {
        private IWebElement ElemLoginTextbox => driver.FindElement(By.XPath(Locators.SignInPage.LOGIN_FIELD));

        private IWebElement ElemPasswordTextbox => driver.FindElement(By.XPath(Locators.SignInPage.PWD_FIELD));

        private IWebElement ElemSigninButton => driver.FindElement(By.XPath(Locators.SignInPage.SIGN_IN_BTN));

        public LogInPage(IWebDriver driver) : base(driver)
        {

        }

        public void SetLogin(string login, string password)
        {
            ElemLoginTextbox.SendKeys(login);
            ElemPasswordTextbox.SendKeys(password);
        }

        public void ClickOnFormLogin()
        {
            ElemSigninButton.Click();
            Thread.Sleep(2000);
        }


        


    }
}

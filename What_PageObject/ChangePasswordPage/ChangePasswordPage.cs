using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;

namespace What_PageObject.ChangePassword

{
    public class ChangePasswordPage : BasePage
    {
        private WebDriverWait wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));

        public void WaitClickDropDownMenu()
        {
            wait.Until(e => e.FindElement(By.XPath("//tbody/tr")));
            ClickElement(Locators.DropDownButton);
        }
        public void ClickChangePasswordButton()
        {
            ClickElement(Locators.ChangePasswordIcon);
        }

        public ChangePasswordPage FillCurrentPasswordField(string passwordText)
        {
            FillField(Locators.CurrentPasswordField, passwordText);
            return this;
        }

        public ChangePasswordPage FillNewPasswordField(string passwordText)
        {
            FillField(Locators.NewPasswordField, passwordText);
            return this;
        }

        public ChangePasswordPage FillConfirmNewPasswordField(string passwordText)
        {
            FillField(Locators.ConfirmNewPasswordField, passwordText);
            return this;
        }

        public void ClickSaveButton()
        {
            ClickElement(Locators.SaveButton);

        }

        public void ClickCancelButton()
        {
            ClickElement(Locators.CancelButton);

        }

        public void ClickConfirmButtonInModalWindow()
        {
            //
            ClickElement(Locators.ConfirmButtonInModalWindow);

        }

        public void ClickCancelButtonInModalWindow()
        {
            ClickElement(Locators.CancelButtonInModalWindow);

        }

        public void Logout()
        {
            ClickElement(Locators.DropDownButton);
            ClickElement(Locators.TopDropdownLogoutButton);
        }


        public string FlashMassage()
        {
            wait.Until(e => e.FindElement(By.XPath("//tbody/tr")));
            return Driver.Current.FindElement(By.XPath("//*[@id='root']/div[1]/div")).Text;
         }

        public void Waiter()
        {
            wait.Until(e => e.FindElement(By.XPath("//tbody/tr")));
            
        }
        public void WaiterLogin()
        {
            wait.Until(e => e.FindElement(By.XPath("//*[@id='email']")));

        }

        



    }

}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.ChangePassword 
  
{
    public class ChangePasswordPage : BasePage
    {
        public ChangePasswordPage(IWebDriver driver) : base(driver)
        {
        }

        public void ClickDropDownMenu()
        {
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
            ClickElement(Locators.ConfirmButtonInModalWindow);

        }

        public void ClickCancelButtonInModalWindow()
        {
            ClickElement(Locators.CancelButtonInModalWindow);

        }









    }

}

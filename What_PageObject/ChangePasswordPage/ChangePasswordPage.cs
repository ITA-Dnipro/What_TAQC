using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.ChangePassword

{
    public class ChangePasswordPage : BasePage
    {
        private WebDriverWait wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));

        public ChangePasswordPage WaitClickDropDownMenu()
        {
            wait.Until(e => e.FindElement(Locators.GroupsPage.TableData));
            ClickElement(Locators.ChangePassword.DropDownButton);
            return this;
        }
        public ChangePasswordPage ClickChangePasswordButton()
        {
            ClickElement(Locators.ChangePassword.ChangePasswordIcon);
            return this;
        }

        public ChangePasswordPage FillCurrentPasswordField(string passwordText)
        {
            FillField(Locators.ChangePassword.CurrentPasswordField, passwordText);
            return this;
        }

        public ChangePasswordPage ClickCurrentPasswordField()
        {
            ClickElement(Locators.ChangePassword.CurrentPasswordField);
            return this;
        }

        public ChangePasswordPage FillNewPasswordField(string passwordText)
        {
            FillField(Locators.ChangePassword.NewPasswordField, passwordText);
            return this;
        }

        public ChangePasswordPage ClickNewPasswordField()
        {
            ClickElement(Locators.ChangePassword.NewPasswordField);
            return this;
        }

        public ChangePasswordPage FillConfirmNewPasswordField(string passwordText)
        {
            FillField(Locators.ChangePassword.ConfirmNewPasswordField, passwordText);
            return this;
        }

        public ChangePasswordPage ClickConfirmNewPasswordField()
        {
            ClickElement(Locators.ChangePassword.ConfirmNewPasswordField);
            return this;
        }

        public ChangePasswordPage ClickSaveButton()
        {
            ClickElement(Locators.ChangePassword.SaveButton);
            return this;

        }

        public ChangePasswordPage ClickCancelButton()
        {
            ClickElement(Locators.ChangePassword.CancelButton);
            return this;

        }

        public ChangePasswordPage ClickConfirmButtonInModalWindow()
        {
            
            ClickElement(Locators.ChangePassword.ConfirmButtonInModalWindow);
            return this;

        }

        public ChangePasswordPage ClickCancelButtonInModalWindow()
        {
            ClickElement(Locators.ChangePassword.CancelButtonInModalWindow);
            return this;

        }

        public ChangePasswordPage Logout()
        {
            ClickElement(Locators.ChangePassword.DropDownButton);
            ClickElement(Locators.ChangePassword.TopDropdownLogoutButton);
            return this;
        }

        public ChangePasswordPage VerifyCompleteChangesPassword()
        {
            Assert.AreEqual("http://localhost:8080/mentors", Driver.Current.Url);
            return this;

        }

        public ChangePasswordPage VerifyCurrentPassThisFieldRequired()//доработать
        {
            string actual = "This field is required";
            string expected = Driver.Current.FindElement(Locators.ChangePassword.ThisFieldRequiredCurrentPass).Text; 
            Assert.AreEqual(actual,expected);
            return this;

        }

        public ChangePasswordPage VerifyNewPassThisFieldRequired()//доработать
        {
            string actual = "This field is required";
            string expected = Driver.Current.FindElement(Locators.ChangePassword.ThisFieldRequiredNewPass).Text;
            Assert.AreEqual(actual, expected);
            return this;

        }

        public ChangePasswordPage VerifyConfirmNewPassThisFieldRequired()//доработать
        {
            string actual = "This field is required";
            string expected = Driver.Current.FindElement(Locators.ChangePassword.ThisFieldRequiredConfirmNewPass).Text;
            Assert.AreEqual(actual, expected);
            return this;

        }


        public ChangePasswordPage Waiter()
        {
            wait.Until(e => e.FindElement(Locators.GroupsPage.TableData));
            return this;


        }
        public ChangePasswordPage WaiterLogin()
        {
            wait.Until(e => e.FindElement(Locators.ChangePassword.EmailAdressField));
            return this;

        }





    }

}

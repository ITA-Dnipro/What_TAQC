//using NUnit.Framework;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using What_Common.DriverManager;

//namespace What_PageObject.ChangePassword

//{
//    public class ChangePasswordPage : BasePage
//    {
//        private WebDriverWait wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));

//        public ChangePasswordPage WaitClickDropDownMenu()
//        {
//            wait.Until(e => e.FindElement(By.XPath("//tbody/tr")));
//            ClickElement(Locators.DropDownButton);
//            return this;
//        }
//        public ChangePasswordPage ClickChangePasswordButton()
//        {
//            ClickElement(Locators.ChangePasswordIcon);
//            return this;
//        }

//        public ChangePasswordPage FillCurrentPasswordField(string passwordText)
//        {
//            FillField(Locators.CurrentPasswordField, passwordText);
//            return this;
//        }

//        public ChangePasswordPage FillNewPasswordField(string passwordText)
//        {
//            FillField(Locators.NewPasswordField, passwordText);
//            return this;
//        }

//        public ChangePasswordPage FillConfirmNewPasswordField(string passwordText)
//        {
//            FillField(Locators.ConfirmNewPasswordField, passwordText);
//            return this;
//        }

//        public ChangePasswordPage ClickSaveButton()
//        {
//            ClickElement(Locators.SaveButton);
//            return this;

//        }

//        public ChangePasswordPage ClickCancelButton()
//        {
//            ClickElement(Locators.CancelButton);
//            return this;

//        }

//        public ChangePasswordPage ClickConfirmButtonInModalWindow()
//        {
            
//            ClickElement(Locators.ConfirmButtonInModalWindow);
//            return this;

//        }

//        public ChangePasswordPage ClickCancelButtonInModalWindow()
//        {
//            ClickElement(Locators.CancelButtonInModalWindow);
//            return this;

//        }

//        public ChangePasswordPage Logout()
//        {
//            ClickElement(Locators.DropDownButton);
//            ClickElement(Locators.TopDropdownLogoutButton);
//            return this;
//        }

//        public ChangePasswordPage VerifyCompleteChangesPassword()
//        {
//            Assert.AreEqual("http://localhost:8080/mentors", Driver.Current.Url);
//            return this;

//        }


//        public ChangePasswordPage VerifyFlashMassage()
//        {
//            wait.Until(e => e.FindElement(By.XPath("//tbody/tr")));
//            Assert.AreEqual((""),Driver.Current.FindElement(By.XPath("//*[@id='root']/div[1]/div")).Text);
//            return this;
//         }

//        public ChangePasswordPage Waiter()
//        {
//            wait.Until(e => e.FindElement(By.XPath("//tbody/tr")));
//            return this;

            
//        }
//        public ChangePasswordPage WaiterLogin()
//        {
//            wait.Until(e => e.FindElement(By.XPath("//*[@id='email']")));
//            return this;

//        }

        



//    }

//}

using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.ChangePassword
{
    public static class Locators
        {
            public static By DropDownButton = By.XPath("//*[@id='root']/nav/div/div[2]/div[2]/span");

       // public static By DropDownButton = By.XPath("//span [@class='header__header__dropdown-icon___1CTJ8']");

            public static By ChangePasswordIcon = By.XPath("//*[@id='root']/nav/div/div[2]/ul/li[2]/a"); //уточнить нейминг кнопки в тк

            public static By EmailAdressField = By.XPath("//*[@id='email']");
            public static By CurrentPasswordField = By.XPath("//*[@id='currentPassword']");
            public static By NewPasswordField = By.XPath("//*[@id='newPassword']");
            public static By ConfirmNewPasswordField = By.XPath("//*[@id='confirmNewPassword']");

            public static By SaveButton = By.XPath("//*[@id='root']/div/div/div/div/form/div/div[5]/div[2]/button");
            public static By CancelButton = By.XPath("//*[@id='root']/div/div/div/div/form/div/div[5]/div[1]/button");

            public static By ConfirmButtonInModalWindow = By.XPath("/html/body/div[3]/div/div/div[3]/button[2]");
            public static By CancelButtonInModalWindow = By.XPath("/html/body/div[3]/div/div/div[3]/button[1]");


            public static By TopDropdownMenuButton = By.XPath("//*[@class='header__header__dropdown-icon___1CTJ8']");
            public static By TopDropdownLogoutButton = By.XPath("//*[@class='header__header__dropdown-list-show___2kO4i']//*[text()='Log Out']");

        
    }
}


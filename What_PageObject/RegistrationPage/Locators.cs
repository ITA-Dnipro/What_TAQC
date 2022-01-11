using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject.RegistrationPage
{
    public static class Locators
    {
        public static By Registration = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/div[4]/div[2]/p/a");
        public static By NamePageRegistration = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/h3");
        public static By NameModalWindowPageRegistration = By.XPath("/html/body/div[3]/div/div/div[1]/h4");
        public static By FieldFirstName = By.XPath("//*[@id=\"firstName\"]");
        public static By FieldLastName = By.XPath("//*[@id=\"lastName\"]");
        public static By FieldEmailAdress = By.XPath("//*[@id=\"email\"]");
        public static By FieldPassword = By.XPath("//*[@id=\"password\"]");
        public static By FieldConfirmPassword = By.XPath("//*[@id=\"confirm-password\"]");
        public static By ButtonSignUp = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/div[6]/button");
    }
}

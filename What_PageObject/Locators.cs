using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_PageObject
{
    public class Locators
    {
        private By Registration = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/div[4]/div[2]/p/a");
        private By NamePageRegistration = By.XPath("//*[@id=\"root\"]/div/div/div/div/div/form/h3");
        private By FieldFirstName = By.XPath("//*[@id=\"firstName\"]");
        private By FieldLastName = By.XPath("//*[@id=\"lastName\"]");
    }
}

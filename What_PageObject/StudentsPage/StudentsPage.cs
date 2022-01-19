using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.Resources;
using What_Common.DriverManager;
using What_PageObject.Course;
using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;

namespace What_PageObject.StudentsPage
{
    public class StudentsPage : BasePageWithSideBar
    {

        public StudentsPage VerifyCardsSwitchButton()
        {
            ClickElement(Locators.Students.CardsIcon);
            WaitUntilElementLoads<StudentsPage>(Locators.Students.DetailsButton);
            IWebElement detailsText = Driver.Current.FindElement(Locators.Students.DetailsButton);
            string expected = "Details";
            string actual = detailsText.Text;
            Assert.AreEqual(expected, actual);
            return this;
        }

        public StudentsPage VerifyListSwitchButton()
        {
            ClickElement(Locators.Students.ListIcon);
            return this;
        }




    }
}

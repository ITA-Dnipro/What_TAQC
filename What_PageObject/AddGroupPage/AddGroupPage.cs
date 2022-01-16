using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;

namespace What_PageObject.AddGroupPage
{
    public class AddGroupPage : BasePage
    {
        public AddGroupPage FillGroupNameField(string groupnameText)
        {
           // FillField(Locators.groupnameField, groupnameText);
            return this;
        }

    }
}

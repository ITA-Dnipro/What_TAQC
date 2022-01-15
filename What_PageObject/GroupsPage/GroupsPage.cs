using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;

namespace What_PageObject.GroupsPage
{
    public class GroupsPage : BasePageWithSideBar
    {
        public GroupsPage TableIconSwitchButton()
        {
            ClickElement(Locators.tableButton);
            return this;

        }

        public GroupsPage CardsIconSwitchButton()
        {
            ClickElement(Locators.cardsButton);
            return this;

        }


    }
}

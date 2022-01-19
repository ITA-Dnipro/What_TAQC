using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using What_Common.DataProvider;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.ChangePassword;
using What_PageObject.GroupsPage;
using What_PageObject.SignInPage;

namespace What_UITest.GroupsTests
{


    public class TableIconsTest : BaseTest
    {
        SignInPage login;
        GroupsPage groupsPage;
        private LoginDetails user;
        [SetUp]


        public void Setup()
        {

            login = new SignInPage();
            groupsPage = new GroupsPage();
            user = Controller.GetUser(Controller.UserRole.Admin);

        }
        [Test]
        public void IconsTableEqual()
        {
            login.LogIn(user.Email,user.Password);

            groupsPage.SidebarNavigateTo<GroupsPage>()
                .WaitUntilElementLoads<GroupsPage>(Locators.GroupsPage.TableData)
                .GetTableData()
                .CardsIconSwitchButton()
                .GetCardsData()
                .VerifyCardsTableData();
        }
    }
}

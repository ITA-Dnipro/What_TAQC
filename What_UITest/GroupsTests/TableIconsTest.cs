using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
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

        [SetUp]


        public void Setup()
        {

            login = new SignInPage(Driver.Current);
            groupsPage = new GroupsPage();


        }
        [Test]
        public void IconsTableEqual()
        {
            login.LogIn("Bernard@secretar.com", "765Rt##asd", "http://localhost:8080/");//прикрутить норм логин


            groupsPage.SidebarNavigateTo<GroupsPage>()
                .WaitUntilElementLoads<GroupsPage>(Locators.GroupsPage.TableData)
                .GetTableData()
                .CardsIconSwitchButton()
                .GetCardsData()
                .VerifyCardsTableData();
        }
    }
}

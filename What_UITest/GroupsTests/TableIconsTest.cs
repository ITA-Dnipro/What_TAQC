//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using What_Common.DriverManager;
//using What_PageObject.ChangePassword;
//using What_PageObject.GroupsPage;
//using What_PageObject.SignInPage;

//namespace What_UITest.GroupsTests
//{
    

//    public class TableIconsTest : BaseTest
//    {
//        SignInPageObject login;
//        GroupsPage groupsPage;

//        [SetUp]


//        public void Setup()
//        {

//            login = new SignInPageObject(Driver.Current);
//            groupsPage = new GroupsPage();


//        }
//        [Test]
//        public void IconsTableEqual()
//        {
//            login.LogIn("Bernard@secretar.com", "765Rt##asd", "http://localhost:8080/");


//            groupsPage.SidebarNavigateTo<GroupsPage>()
//                .WaitUntilElementLoads<GroupsPage>(By.XPath("//tbody/tr"))
//                .GetTableData()
//                .CardsIconSwitchButton()
//                .VerifyCardsTableData();
//        }
//    }
//}

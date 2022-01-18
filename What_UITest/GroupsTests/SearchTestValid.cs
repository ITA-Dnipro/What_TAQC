using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DataProvider;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.DataProvider;
using What_PageObject.GroupsPage;
using What_PageObject.SignInPage;

namespace What_UITest
{
    public class VerifySearchField : BaseTest
    {
        SignInPage login;
        //LoginDetails admin;
        
        GroupsPage groupsPage;
        [SetUp]

        public void Setup()
        {
           // admin = Controller.GetUser(Controller.UserRole.Admin);
            groupsPage = new GroupsPage();
            login = new SignInPage(Driver.Current);
        }

        [Test(Description = "")]
        public void VerifySearchFieldAsAdminValidValues()
        {
           login.LogIn("Bernard@secretar.com", "765Rt##asd", "http://localhost:8080/");//прикрутить норм логин
            //new SignInPage(Driver.Current).LogIn(admin.Email, admin.Password, "http://localhost:8080/");
            groupsPage.SidebarNavigateTo<GroupsPage>()
            .WaitUntilElementLoads<GroupsPage>(Locators.GroupsPage.TableData)
            .VerifySearch();


        }
    }
}
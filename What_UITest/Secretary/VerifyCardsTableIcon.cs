using System;
using NUnit.Framework;
using What_Common.Resources;
using What_Common.DataProvider;
using What_Common.DriverManager;
using What_PageObject.Secretaries;
using What_PageObject.SignInPage;

namespace What_UITest.Secretary
{
    public class VerifyCardsTableIcon: BaseTest
    {
        LoginDetails admin;
        LoginDetails secretary;       

        [SetUp]
        public void Setup()
        {
            admin = Controller.GetUser(Controller.UserRole.Admin);
            secretary = Controller.GetUser(Controller.UserRole.Secretary);
        }

        [Test(Description = "")]
        public void VerifyCardsTableIcon_AsAdmin()
        {
            new SignInPage().LogIn(admin.Email, admin.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .CompareCardsDataWithTableData();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Current.Close();
        }
    }
}
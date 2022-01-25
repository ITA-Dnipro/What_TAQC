using System;
using NUnit.Framework;
using What_Common.Resources;
using What_Common.DataProvider;
using What_Common.DriverManager;
using What_PageObject.Secretaries;
using What_PageObject.SignInPage;

namespace What_UITest.Secretary
{
    public class VerifySearchField : BaseTest
    {
        LoginDetails admin;
        LoginDetails secretary;       

        [SetUp]
        public void Setup()
        {
            admin = Controller.GetUser(Controller.UserRole.Admin);
            secretary = Controller.GetUser(Controller.UserRole.Secretary);
        }

        [Test(Description = "DP220TAQC-102")]
        public void VerifySearchField_AsAdmin_ValidValues()
        {
            new SignInPage().LogIn(admin.Email, admin.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .CompareSearchDatWithFirstDataFromTable();
        }

        [Test(Description = "DP220TAQC-102")]
        public void VerifySearchField_AsSecretary_ValidValues()
        {
            new SignInPage().LogIn(secretary.Email, secretary.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .CompareSearchDatWithFirstDataFromTable();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Current.Close();
        }
    }
}
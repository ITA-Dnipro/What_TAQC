using NUnit.Framework;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject.SecretariesPage;
using What_PageObject.SignInPage;

namespace What_UITest
{
    public class VerifySearchFieldSecretariesPage : BaseTest
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
                .GetRandomNameFromTable()
                .FillSearchField()
                .CompareSearchData();
        }

        [Test(Description = "DP220TAQC-102")]
        public void VerifySearchField_AsSecretary_ValidValues()
        {
            new SignInPage().LogIn(secretary.Email, secretary.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .GetRandomNameFromTable()
                .FillSearchField()
                .CompareSearchData();
        }

        [Test(Description = "DP220TAQC-102")]
        public void VerifySearchField_AsAdmin_InvalidValues()
        {
            new SignInPage().LogIn(admin.Email, admin.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .GetRandomNameFromTable()
                .FillSearchField(Resources.Secretary.invalidName)
                .CompareSearchDataInvalid();
        }
        [Test(Description = "DP220TAQC-102")]
        public void VerifySearchField_AsSecretary_InvalidValues()
        {
            new SignInPage().LogIn(secretary.Email, secretary.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .GetRandomNameFromTable()
                .FillSearchField(Resources.Secretary.invalidName)
                .CompareSearchDataInvalid();
        }
    }
}
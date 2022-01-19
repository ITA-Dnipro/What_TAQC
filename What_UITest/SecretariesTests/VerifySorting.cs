using NUnit.Framework;
using What_Common.DataProvider;
using What_PageObject.SecretariesPage;
using What_PageObject.SignInPage;

namespace What_UITest
{
    public class VerifySorting : BaseTest
    {
        LoginDetails admin;
        LoginDetails secretary;       

        [SetUp]
        public void Setup()
        {
            admin = Controller.GetUser(Controller.UserRole.Admin);
            secretary = Controller.GetUser(Controller.UserRole.Secretary);
        }

        [Test(Description = "DP220TAQC-74")]
        public void VerifySearchField_AsAdmin_ValidValues()
        {
            new SignInPage().LogIn(admin.Email, admin.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .ClickSortByName()
                .VerifySortingByFirstNameByAsc()
                .ClickSortByName()
                .VerifySortingByFirstNameByDesc()
                .ClickSortBySurname()
                .VerifySortingByLastNameByAsc()
                .ClickSortBySurname()
                .VerifySortingByLastNameByDesc()
                .ClickSortByEmail()
                .VerifySortingByEmailByAsc()
                .ClickSortByEmail()
                .VerifySortingByEmailByDesc();
        }

        [Test(Description = "DP220TAQC-74")]
        public void VerifySearchField_AsSecretary_ValidValues()
        {
            new SignInPage().LogIn(secretary.Email, secretary.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .ClickSortByName()
                .VerifySortingByFirstNameByAsc()
                .ClickSortByName()
                .VerifySortingByFirstNameByDesc()
                .ClickSortBySurname()
                .VerifySortingByLastNameByAsc()
                .ClickSortBySurname()
                .VerifySortingByLastNameByDesc()
                .ClickSortByEmail()
                .VerifySortingByEmailByAsc()
                .ClickSortByEmail()
                .VerifySortingByEmailByDesc();
        }
    }
}
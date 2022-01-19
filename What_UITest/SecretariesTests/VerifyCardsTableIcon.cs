using NUnit.Framework;
using What_Common.DataProvider;
using What_PageObject.SecretariesPage;
using What_PageObject.SignInPage;

namespace What_UITest
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

        [Test(Description = "DP220TAQC-73")]
        public void VerifyCardsTableIcon_AsAdmin()
        {
            new SignInPage().LogIn(admin.Email, admin.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .GetTableData()
                .ClickCardsButton()
                .GetCardsData()
                .CompareCardsDataWithTableData();
        }

        [Test(Description = "DP220TAQC-73")]
        public void VerifyCardsTableIcon_AsSecretary()
        {
            new SignInPage().LogIn(secretary.Email, secretary.Password);
            new SecretariesPage()
                .SidebarNavigateTo<SecretariesPage>()
                .WaitTableData()
                .GetTableData()
                .ClickCardsButton()
                .GetCardsData()
                .CompareCardsDataWithTableData();
        }
    }
}
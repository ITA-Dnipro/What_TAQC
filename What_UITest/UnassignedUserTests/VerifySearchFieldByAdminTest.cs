using NUnit.Framework;
using What_Common.DataProvider;
using What_Common.Resources;
using What_PageObject.Secretaries;
using What_PageObject.SignInPage;
using What_PageObject.UnassignedUsersPage;

namespace What_UITest.UnassignedUserTests
{
    public class VerifySearchFieldByAdminTest : BaseTest
    {
        private LoginDetails admin;

        [SetUp]
        public void Setup()
        {
            admin = Controller.GetUser(Controller.UserRole.Admin);
            new SignInPage().LogIn(admin.Email, admin.Password);
        }

        [Test]
        public void VerifySearchField_AsAdmin_ValidValues()
        {
            new SecretariesPage()
                .SidebarNavigateTo<UnassignedUserPage>()
                .WaitUntilElementLoads<UnassignedUserPage>(Locators.UnassignedUser.TableData)
                .CompareSearchDatWithFirstDataFromTable();
        }
    }
}
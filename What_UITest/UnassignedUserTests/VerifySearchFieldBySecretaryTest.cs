using NUnit.Framework;
using What_Common.DataProvider;
using What_Common.Resources;
using What_PageObject.SecretariesPage;
using What_PageObject.SignInPage;
using What_PageObject.UnassignedUsersPage;

namespace What_UITest.UnassignedUserTests
{
    public class VerifySearchFieldBySecretaryTest : BaseTest
    {
        private LoginDetails secretary;

        [SetUp]
        public void Setup()
        {
            secretary = Controller.GetUser(Controller.UserRole.Secretary);
            new SignInPage().LogIn(secretary.Email, secretary.Password);
        }

        [Test]
        public void VerifySearchField()
        {
            new SecretariesPage()
                .SidebarNavigateTo<UnassignedUserPage>()
                .WaitUntilElementLoads<UnassignedUserPage>(Locators.UnassignedUser.TableData)
                .CompareSearchDatWithFirstDataFromTable();
        }
    }
}
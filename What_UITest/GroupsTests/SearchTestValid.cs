using NUnit.Framework;
using What_Common.DataProvider;
using What_Common.Resources;
using What_PageObject.GroupsPage;
using What_PageObject.SignInPage;

namespace What_UITest
{


    public class VerifySearchField : BaseTest
    {
        private SignInPage login;
        private LoginDetails user;
        private GroupsPage groupsPage;

        [SetUp]
        public void Setup()
        {
            user = Controller.GetUser(Controller.UserRole.Admin);
            groupsPage = new GroupsPage();
            login = new SignInPage();
        }

        [Test(Description = "DP220TAQC-197")]
        public void VerifySearchFieldAsAdminValidValues()
        {
            login.LogIn(user.Email, user.Password);
            groupsPage.SidebarNavigateTo<GroupsPage>()
            .WaitUntilElementLoads<GroupsPage>(Locators.GroupsPage.TableData)
            .VerifySearch();
        }
    }
}
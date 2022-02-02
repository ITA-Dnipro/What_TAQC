using NUnit.Framework;
using What_Common.DataProvider;
using What_PageObject.SignInPage;
using What_PageObject.UnassignedUsersPage;

namespace What_UITest.UnassignedUserTests
{
    public class ClickSortingButtonsTest : BaseTest
    {
        private SignInPage? signInPage;
        private UnassignedUserPage? unassignedUser;
        private LoginDetails? user;

        [SetUp]
        public void Setup()
        {
            signInPage = new SignInPage();
            unassignedUser = new UnassignedUserPage();
            user = Controller.GetUser(Controller.UserRole.Admin);
            signInPage.LogIn(user.Email, user.Password);
        }

        [Test]
        public void SortingTest()
        {
            unassignedUser.SidebarNavigateTo<UnassignedUserPage>()
                          .WaitUntilElementLoads<UnassignedUserPage>(What_Common.Resources.Locators.UnassignedUser.TableData)
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
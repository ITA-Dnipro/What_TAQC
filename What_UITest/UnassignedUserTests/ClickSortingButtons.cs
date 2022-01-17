using NUnit.Framework;
using What_Common.DriverManager;
using What_PageObject.SignInPage;
using What_PageObject.UnassignedUsersPage;

namespace What_UITest.UnassignedUserTests
{
    public class ClickSortingButtons : BaseTest
    {
        private SignInPageObject signInPage;
        private UnassignedUserPage unassignedUser;

        [SetUp]
        public void Setup()
        {
            signInPage = new SignInPageObject(Driver.Current);
            unassignedUser = new UnassignedUserPage();
            signInPage.LogIn("james.smith@example.com", "Nj_PJ7K9", "http://localhost:8080/");
        }

        [Test]
        //[Repeat(5)]
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

        [TearDown]
        public void AfterTest()
        {

        }
    }
}
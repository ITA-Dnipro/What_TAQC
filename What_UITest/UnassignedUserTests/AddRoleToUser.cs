using NUnit.Framework;
using System;
using What_Common.DriverManager;
using What_PageObject;
using What_PageObject.SignInPage;
using What_PageObject.UnassignedUsersPage;

namespace What_UITest.UnassignedUserTests
{
    public class AddRoleToUser : BaseTest
    {
        private SignInPage signInPage;
        private UnassignedUserPage unassignedUser;
        private Random rnd = new Random();

        [SetUp]
        public void Setup()
        {
            signInPage = new SignInPage();
            unassignedUser = new UnassignedUserPage();
            signInPage.LogIn("james.smith@example.com", "Nj_PJ7K9");
        }

        [Test]
        //[Repeat(5)]
        public void ChooseRoleTest()
        {
            int row = rnd.Next(1, unassignedUser.GetCurretnPageTableData() + 1);

            unassignedUser.SidebarNavigateTo<UnassignedUserPage>()
                          .WaitUntilElementLoads<UnassignedUserPage>(What_Common.Resources.Locators.UnassignedUser.TableData)
                          .SetRoleToCurrentUser(row, (int)ChooseRole.student)
                          .ClickAddRoleButton(row);
        }

        [TearDown]
        public void AfterTest()
        {

        }
    }
}
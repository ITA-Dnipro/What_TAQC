using NUnit.Framework;
using System;
using What_Common.DataProvider;
using What_Common.Resources;
using What_PageObject.Secretaries;
using What_PageObject.SignInPage;
using What_PageObject.UnassignedUsersPage;
using static What_PageObject.UnassignedUsersPage.UnassignedUserHelper;

namespace What_UITest.UnassignedUserTests
{
    public class AddSecretaryRoleToUserTest : BaseTest
    {
        private SignInPage signInPage;
        private UnassignedUserPage unassignedUser;
        private LoginDetails user;
        private UnassignedUserHelper helper = new UnassignedUserHelper();
        private Random rnd = new Random();

        [SetUp]
        public void Setup()
        {
            signInPage = new SignInPage();
            unassignedUser = new UnassignedUserPage();
            user = Controller.GetUser(Controller.UserRole.Admin);
            helper.GenerateNewUser();
            signInPage.LogIn(user.Email, user.Password);
        }

        [Test]
        public void ChooseRoleTest()
        {
            int row = rnd.Next(1, unassignedUser.GetCurretnPageTableDataCount() + 1);
            string user;

            unassignedUser.SidebarNavigateTo<UnassignedUserPage>()
                          .WaitUntilElementLoads<UnassignedUserPage>(Locators.UnassignedUser.TableData)
                          .GetUserFromRow(row, out user)
                          .SetRoleToCurrentUser(row, (int)ChooseRole.secretary)
                          .ClickAddRoleButton(row)
                          .SidebarNavigateTo<SecretariesPage>()
                          .WaitUntilElementLoads<UnassignedUserPage>(Locators.UnassignedUser.TableData)
                          .VerifyUserExistInTable(user);
        }
    }
}
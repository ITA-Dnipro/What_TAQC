using NUnit.Framework;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.GroupsPage;
using What_PageObject.SignInPage;

namespace What_UITest
{
    public class VerifySearchField : BaseTest
    {
        private SignInPage login;

        //LoginDetails admin;

        private GroupsPage groupsPage;
        [SetUp]

        public void Setup()
        {
            // admin = Controller.GetUser(Controller.UserRole.Admin);
            groupsPage = new GroupsPage();
            login = new SignInPage();
        }

        [Test(Description = "")]
        public void VerifySearchFieldAsAdminValidValues()
        {
            login.LogIn(Resources.ChangePassword.secretaryEmail, Resources.ChangePassword.secretaryPassword);//прикрутить норм логин
            //new SignInPage(Driver.Current).LogIn(admin.Email, admin.Password);
            groupsPage.SidebarNavigateTo<GroupsPage>()
            .WaitUntilElementLoads<GroupsPage>(Locators.GroupsPage.TableData)
            .VerifySearch();


        }
    }
}
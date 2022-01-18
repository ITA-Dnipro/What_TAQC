using NUnit.Framework;
using What_PageObject.SignInPage;
using What_Common.DataProvider;

namespace What_UITest.SignInTests
{
    public class LogInAdminTestValid : BaseTest
    {
        private LoginDetails user = Controller.GetUser(Controller.UserRole.Admin);

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void LogInAdminValid()
        {
            var SignInPage = new SignInPage();
            SignInPage.IsAtPage();
            SignInPage
                .LogIn(user.Email, user.Password)
                .VerifyLogInAsAdmin();
        }
    }
}

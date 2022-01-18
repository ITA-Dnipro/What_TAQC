using NUnit.Framework;
using What_PageObject.SignInPage;
using What_Common.DataProvider;

namespace What_UITest.SignInTests
{
    public class LogInSecretaryTestValid : BaseTest
    {
        private LoginDetails user = Controller.GetUser(Controller.UserRole.Secretary);

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void LogInSecretaryValid()
        {
            var SignInPage = new SignInPage();
            SignInPage.IsAtPage();
            SignInPage
                .LogIn(user.Email, user.Password)
                .VerifyLogInAsSecretary();
        }
    }
}

using NUnit.Framework;
using What_PageObject.SignInPage;
using What_Common.DataProvider;

namespace What_UITest.SignInTests
{
    public class LogInStudentTestValid : BaseTest
    {
        private LoginDetails user = Controller.GetUser(Controller.UserRole.Student);

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void LogInStudentValid()
        {
            var SignInPage = new SignInPage();
            SignInPage.IsAtPage();
            SignInPage
                .LogIn(user.Email, user.Password)
                .VerifyLogInAsStudent();
        }
    }
}

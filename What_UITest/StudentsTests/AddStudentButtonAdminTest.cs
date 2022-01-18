using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.StudentsPage;
using What_Common.DataProvider;

namespace What_UITest.StudentsTests
{
    public class AddStudentButtonAdminTest : BaseTest
    {
        private LoginDetails user = Controller.GetUser(Controller.UserRole.Admin);

        [SetUp]
        public void Setup()
        {
            var SignInPage = new SignInPage();

            SignInPage.IsAtPage();
            SignInPage
                .LogIn(user.Email, user.Password)
                .VerifyLogInAsAdmin();
        }

        [Test]
        public void ClickAddStudentButton()
        {
            var StudentsPage = new StudentsPage();
            StudentsPage
                .ClickAddStudentButton()
                .VerifyAddStudent();
        }
    }
}

using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.StudentsPage;
using What_Common.DataProvider;

namespace What_UITest.StudentsTests
{
    public class AddStudentButtonSecretaryTest : BaseTest
    {
        private LoginDetails user = Controller.GetUser(Controller.UserRole.Secretary);

        [SetUp]
        public void Setup()
        {
            var SignInPage = new SignInPage();

            SignInPage.IsAtPage();
            SignInPage
                .LogIn(user.Email, user.Password)
                .VerifyLogInAsSecretary();
        }

        [Test]
        public void ClickAddStudentButton()
        {
            var StudentsPage = new StudentsPage();
            StudentsPage
                .ClickStudentsSideBar()
                .ClickAddStudentButton()
                .VerifyAddStudent();
        }
    }
}

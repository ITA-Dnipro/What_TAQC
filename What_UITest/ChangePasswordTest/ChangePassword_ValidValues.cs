using NUnit.Framework;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.ChangePassword;
using What_PageObject.SignInPage;

namespace What_UITest.ChangePasswordTests
{
    public class ChangePassword_ValidValues : BaseTest
    {
        

        SignInPage login;



        ChangePasswordPage passwordPage;

        [SetUp]


        public void Setup()
        {



            login = new SignInPage();
            passwordPage = new ChangePasswordPage();

        }



        [Test]
        public void ChangePasswordAsSecretary()
        {
            login.LogIn(Resources.ChangePassword.secretarEmail, Resources.ChangePassword.passwordOld);
            passwordPage.WaitClickDropDownMenu()
                 .ClickChangePasswordButton()
                 .FillCurrentPasswordField(Resources.ChangePassword.passwordOld)
                 .FillNewPasswordField(Resources.ChangePassword.passwordNew)
                 .FillConfirmNewPasswordField(Resources.ChangePassword.passwordNew)
                 .ClickSaveButton()
                 .ClickConfirmButtonInModalWindow()
                 .Logout()
                 .WaiterLogin();
            login.LogIn(Resources.ChangePassword.secretarEmail, Resources.ChangePassword.passwordNew);
            passwordPage.Waiter()
            .VerifyCompleteChangesPassword()
            .Logout();


        }

        [TearDown]

        public void ChangePasswordBack()
        {
            login.LogIn(Resources.ChangePassword.secretarEmail, Resources.ChangePassword.passwordNew);
            passwordPage.WaitClickDropDownMenu()
             .ClickChangePasswordButton()
             .FillCurrentPasswordField(Resources.ChangePassword.passwordNew)
             .FillNewPasswordField(Resources.ChangePassword.passwordOld)
             .FillConfirmNewPasswordField(Resources.ChangePassword.passwordOld)
             .ClickSaveButton()
             .ClickConfirmButtonInModalWindow()
             .Waiter();
            

        }
    }
}

        



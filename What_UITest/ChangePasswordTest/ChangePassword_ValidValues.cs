using NUnit.Framework;
using What_Common.DriverManager;
using What_PageObject.ChangePassword;
using What_PageObject.SignInPage;

namespace What_UITest.ChangePasswordTests
{
    public class ChangePassword_ValidValues : BaseTest
    {
        private const string PasswordOld = "765Rt##asd4";
        private const string PasswordNew = "765Rt##asd";

        SignInPageObject login;



        ChangePasswordPage page;

        [SetUp]


        public void Setup()
        {

            login = new SignInPageObject(Driver.Current);
            page = new ChangePasswordPage();//назвать так же 

        }



        [Test]
        public void ChangePasswordAsSecretary()
        {
            login.LogIn("Adrian@secretar.com", PasswordOld, "http://localhost:8080/");
            page.WaitClickDropDownMenu()
                 .ClickChangePasswordButton()
                 .FillCurrentPasswordField(PasswordOld)
                 .FillNewPasswordField(PasswordNew)
                 .FillConfirmNewPasswordField(PasswordNew)
                 .ClickSaveButton()
                 .ClickConfirmButtonInModalWindow()
                 .VerifyFlashMassage()
                 .Logout();
               page.WaiterLogin();
               login.LogIn("Adrian@secretar.com", PasswordNew, "http://localhost:8080/");
               page.Waiter()
               .VerifyCompleteChangesPassword()
               .Logout();


        }

        [TearDown]

        public void Aftertest()
        {


            ChangePasswordBack();//найти ему своем место


        }

        private void ChangePasswordBack()
        {
            login.LogIn("Adrian@secretar.com", PasswordNew, null);
            page.WaitClickDropDownMenu()
             .ClickChangePasswordButton()
             .FillCurrentPasswordField(PasswordNew)
             .FillNewPasswordField(PasswordOld)
             .FillConfirmNewPasswordField(PasswordOld)
             .ClickSaveButton()
             .ClickConfirmButtonInModalWindow()
             .VerifyFlashMassage();

        }


    }
}
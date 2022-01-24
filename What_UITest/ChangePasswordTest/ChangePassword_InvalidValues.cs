using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.ChangePassword;
using What_PageObject.SignInPage;

namespace What_UITest.ChangePasswordTest
{
    public class ChangePassword_InvalidValues : BaseTest
    {
        SignInPage login;
        ChangePasswordPage passwordPage;

        [SetUp]
        public void Setup()
        {
            login = new SignInPage();
            passwordPage = new ChangePasswordPage();
        }


        [Test(Description = "DP220TAQC-77")]

        public void ChangePasswordAsSecretary()
        {
            login.LogIn(Resources.ChangePassword.secretarEmail, Resources.ChangePassword.passwordOld);
            passwordPage.WaitClickDropDownMenu()
                 .ClickChangePasswordButton()
                 .ClickCurrentPasswordField()
                 .ClickNewPasswordField()
                 .VerifyCurrentPassThisFieldRequired()
                 .FillCurrentPasswordField(Resources.ChangePassword.passwordOld)
                 .VerifyNewPassThisFieldRequired()
                 .FillNewPasswordField(Resources.ChangePassword.passwordNew)
                 .ClickConfirmNewPasswordField()
                 .ClickNewPasswordField()
                 .VerifyConfirmNewPassThisFieldRequired();
        }

    }
}
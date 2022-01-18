using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_Common.DriverManager;
using What_PageObject.ChangePassword;
using What_PageObject.SignInPage;

namespace What_UITest.ChangePasswordTest
{
    public class ChangePassword_InvalidValues : BaseTest
    {
        SignInPage login;
        ChangePasswordPage passwordPage;

        private const string PasswordOld = "765Rt##asd4";
        private const string PasswordNew = "765Rt##asd";

        [SetUp]


        public void Setup()
        {



            login = new SignInPage(Driver.Current);
            passwordPage = new ChangePasswordPage();

        }



        [Test]

        public void ChangePasswordAsSecretary()
        {
            login.LogIn("Adrian@secretar.com", PasswordOld, "http://localhost:8080/");
            passwordPage.WaitClickDropDownMenu()
                 .ClickChangePasswordButton()
                 .ClickCurrentPasswordField()
                 .ClickNewPasswordField()
                 .VerifyCurrentPassThisFieldRequired()
                 .FillCurrentPasswordField(PasswordOld)
                 .VerifyNewPassThisFieldRequired()
                 .FillNewPasswordField(PasswordNew)
                 .ClickConfirmNewPasswordField()
                 .ClickNewPasswordField()
                 .VerifyConfirmNewPassThisFieldRequired();


                 
                 


        }

    }
}
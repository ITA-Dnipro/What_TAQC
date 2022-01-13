﻿using NUnit.Framework;
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
            login.LogIn("Adrian@secretar.com", PasswordOld, null);
            page.WaitClickDropDownMenu();
            page.ClickChangePasswordButton();
            page.FillCurrentPasswordField(PasswordOld)
                 .FillNewPasswordField(PasswordNew)
                 .FillConfirmNewPasswordField(PasswordNew)
                 .ClickSaveButton();


            page.ClickConfirmButtonInModalWindow();
            page.FlashMassage();



            page.Logout();



            page.WaiterLogin();

            login.LogIn("Adrian@secretar.com", PasswordNew, null);


            page.Waiter();
            Assert.AreEqual("http://localhost:8080/mentors", Driver.Current.Url);//вынести ассерты в отд регион

            page.Logout();


        }

        [TearDown]

        public void Aftertest()
        {


            ChangePasswordBack();//найти ему своем место


        }

        private void ChangePasswordBack()
        {
            login.LogIn("Adrian@secretar.com", PasswordNew, null);
            page.WaitClickDropDownMenu();
            page.ClickChangePasswordButton();
            page.FillCurrentPasswordField(PasswordNew)
                 .FillNewPasswordField(PasswordOld)
                 .FillConfirmNewPasswordField(PasswordOld)
                 .ClickSaveButton();


            page.ClickConfirmButtonInModalWindow();
            page.FlashMassage();

        }


    }
}
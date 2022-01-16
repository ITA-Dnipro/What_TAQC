using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using System.Threading;
using What_Common.DriverManager;
using What_PageObject.ChangePassword;
using What_PageObject.SignInPage;

namespace What_UITest.ChangePasswordTests
{
    public class ChangePassword_ValidValues : BaseTest.BaseTest
    {
        private const string PasswordOld = "765Rt##asd4";
        private const string PasswordNew = "765Rt##asd";

        SignInPageObject login;

        //Login login;



        ChangePasswordPage page;

        [SetUp]


        public void Setup()
        {
            
           

            login = new SignInPageObject(Driver.Current);
            page = new ChangePasswordPage();


        }


        


        [Test]
        public void ChangePasswordAsSecretary()
        {
            login.LogIn("Adrian@secretar.com", PasswordOld);
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

            login.LogIn("Adrian@secretar.com", PasswordNew);


            page.Waiter();
            Assert.AreEqual("http://localhost:8080/mentors", Driver.Current.Url);

            page.Logout();


        }

        [TearDown]

        public void Aftertest()
        {
            

            ChangePasswordBack();

           
        }

        private void ChangePasswordBack()
        {
            login.LogIn("Adrian@secretar.com", PasswordNew);
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
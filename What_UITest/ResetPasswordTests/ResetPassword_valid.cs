using NUnit.Framework;
using ResetPassword;
using System.Collections.Generic;
using What_Common.DriverManager;
using What_Common.Resources;
using What_Common.Utils;
using What_PageObject.ResetPasswordPage.Model;

namespace What_UITest.ResetPassword
{
    public class ResetPassword_valid : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Current.Navigate().GoToUrl(Resources.WhatResetPasswordUrl);
        }

        [Test]
        [TestCaseSource(nameof(GetValidResetPassword))]
        public void EnterValidNewPasswordClickModalAndRedirectedToAuth(ResetPasswordModel valid)
        {
            new ResetPasswordPage()
                .VerifyConfirmButtonIsDisable()
                .FillEmail(valid.Email)
                .VerifyEmailFilled(valid.Email)
                .FillNewPassword(valid.NewPassword)
                .VerifyNewPasswordFilled(valid.NewPassword)
                .FillConfirmPassword(valid.ConfirmPassword)
                .VerifyConfirmPasswordFilled(valid.ConfirmPassword)
                .VerifyConfirmButtonIsEnable()
                .ClickConfirmButton()
                .ClickBackButton()
                .VerifyRedirectToAuthPage();

        }
        private static IEnumerable<ResetPasswordModel> GetValidResetPassword()
        {
            return Helpers.ReadJson<ResetPasswordModel>(@"d:\Data\validResetPassword.json");
        }
    }
}

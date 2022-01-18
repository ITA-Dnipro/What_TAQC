using NUnit.Framework;
using ResetPassword;
using System.Collections.Generic;
using What_Common.DriverManager;
using What_Common.Resources;
using What_Common.Utils;
using What_PageObject.ResetPasswordPage.Model;

namespace What_UITest.ResetPassword
{
    public class ResetPassword_invalid : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Driver.Current.Navigate().GoToUrl(Resources.WhatResetPasswordUrl);
        }
        [Test(Description = "DP220TAQC-108")]
        [TestCaseSource(nameof(GetInvalidResetPassword))]
        public void EnterInvalidDataUserCanSeeErrors(ResetPasswordModel invalid)
        {
            new ResetPasswordPage()
                .FillEmail(invalid.Email)
                .VerifyEmailError(invalid.EmailError)
                .FillNewPassword(invalid.NewPassword)
                .VerifyNewPasswordError(invalid.NewPasswordError)
                .FillConfirmPassword(invalid.ConfirmPassword)
                .VerifyConfirmPasswordError(invalid.ConfirmPasswordError);

        }
        private static IEnumerable<ResetPasswordModel> GetInvalidResetPassword()
        {
            return Helpers.ReadJson<ResetPasswordModel>(@"d:\Data\invalidResetPassword.json");
        }
    }
}

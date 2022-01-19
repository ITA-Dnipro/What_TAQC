using NUnit.Framework;
using What_PageObject.ForgotPasswordPage;
using What_Common.Resources;
using What_Common.DataProvider;
using What_Common.DriverManager;

namespace What_UITest
{
    public class VerifyThatPasswordResetRequestCanWasSend : BaseTest
    {      
        [Test(Description = "DP220TAQC-41")]
        public void VerifyThatPasswordResetRequestCanWasSend_ValidValues()
        {
            LoginDetails user = Controller.GetUser(Controller.UserRole.Student);
            new ForgotPasswordPage()
                .ClickForgotPasswordLink()
                .FillEmailField(user.Email)
                .ClickSendButton()
                .VerifyTextValueInModalWindow();
        }

        [Test(Description = "DP220TAQC-60")]
        public void VerifyThatPasswordResetRequestCanWasSend_InvalidValuesEmail()
        {
            new ForgotPasswordPage()
                .ClickForgotPasswordLink()
                .FillEmailField(Resources.ForgotPassword.invalidEmail)
                .ClickForgotPasswordLabel()
                .ClickSendButton();
            Assert.AreEqual(Resources.ForgotPassword.invalidEmailError, new ForgotPasswordPage().GetTextValue(Locators.ForgotPassword.emailAddressError));
        }

        [Test(Description = "DP220TAQC-60")]
        public void VerifyThatPasswordResetRequestCanWasSend_DoesntExistValues()
        {
            new ForgotPasswordPage()
                .ClickForgotPasswordLink()
                .FillEmailField(Resources.ForgotPassword.doesntExistEmail)
                .ClickSendButton();
            Assert.AreEqual(Resources.ForgotPassword.DoesntExistEmailError(Resources.ForgotPassword.doesntExistEmail), new ForgotPasswordPage().GetTextValue(Locators.ForgotPassword.sendButtonError));
        }

        [Test(Description = "DP220TAQC-60")]
        public void VerifyThatPasswordResetRequestCanWasSend_EmptyValuesEmail()
        {
            new ForgotPasswordPage()
                .ClickForgotPasswordLink()
                .FillEmailField("")
                .ClickForgotPasswordLabel()
                .ClickSendButton();
            Assert.AreEqual(Resources.ForgotPassword.emptyEmailError, new ForgotPasswordPage().GetTextValue(Locators.ForgotPassword.emailAddressError));
        }
    }
}
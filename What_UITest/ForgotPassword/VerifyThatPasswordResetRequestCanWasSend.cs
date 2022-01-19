using NUnit.Framework;
using What_PageObject.ForgotPassword;
using What_Common.Resources;
using What_Common.DataProvider;
using What_Common.DriverManager;

namespace What_UITest
{
    public class VerifyThatPasswordResetRequestCanWasSend : BaseTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test(Description = "DP220TAQC-41")]
        [TestCase(Resources.ForgotPassword.modalWindowText)]
        public void VerifyThatPasswordResetRequestCanWasSend_ValidValues(string expected)
        {
            LoginDetails user = Controller.GetUser(Controller.UserRole.Student);
            new ForgotPasswordPage()
                .ClickForgotPasswordLink()
                .FillEmailField(user.Email)
                .ClickSendButton();
            Assert.AreEqual(expected, new ForgotPasswordPage().GetTextValue(Locators.ForgotPassword.modalWindowText));
        }

        [Test(Description = "DP220TAQC-60")]
        [TestCase(Resources.ForgotPassword.invalidEmail, Resources.ForgotPassword.invalidEmailError)]
        public void VerifyThatPasswordResetRequestCanWasSend_InvalidValuesEmail(string email, string expected)
        {
            new ForgotPasswordPage()
                .ClickForgotPasswordLink()
                .FillEmailField(email)
                .ClickForgotPasswordLabel()
                .ClickSendButton();
            Assert.AreEqual(expected, new ForgotPasswordPage().GetTextValue(Locators.ForgotPassword.emailAddressError));
        }

        [Test(Description = "DP220TAQC-60")]
        [TestCase(Resources.ForgotPassword.invalidEmail, Resources.ForgotPassword.emptyEmailError)]
        public void VerifyThatPasswordResetRequestCanWasSend_EmptyValuesEmail(string email, string expected)
        {
            new ForgotPasswordPage()
                .ClickForgotPasswordLink()
                .FillEmailField("")
                .ClickForgotPasswordLabel()
                .ClickSendButton();
            Assert.AreEqual(expected, new ForgotPasswordPage().GetTextValue(Locators.ForgotPassword.emailAddressError));
        }

        [Test(Description = "DP220TAQC-60")]
        [TestCase(Resources.ForgotPassword.doesntExistEmail)]
        public void VerifyThatPasswordResetRequestCanWasSend_DoesntExistValues(string email)
        {
            new ForgotPasswordPage()
                .ClickForgotPasswordLink()
                .FillEmailField(email)
                .ClickSendButton();
            Assert.AreEqual(Resources.ForgotPassword.DoesntExistEmailError(Resources.ForgotPassword.doesntExistEmail), new ForgotPasswordPage().GetTextValue(Locators.ForgotPassword.sendButtonError));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Current.Close();
        }
    }
}
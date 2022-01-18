using NUnit.Framework;
using What_PageObject.SignInPage;

namespace What_UITest.SignInTests
{
    public class ForgotPasswordButtonTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ClickForgotPasswordButton()
        {
            var SignInPage = new SignInPage();
            SignInPage
                .ClickRegistrationButton()
                .VerifyRegistrationButton();
        }
    }
}

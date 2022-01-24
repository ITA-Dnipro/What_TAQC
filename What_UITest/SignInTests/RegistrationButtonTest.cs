using NUnit.Framework;
using What_PageObject.SignInPage;

namespace What_UITest.SignInTests
{
    public class RegistrationButtonTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ClickRegistrationButton()
        {
            var SignInPage = new SignInPage();
            SignInPage
                .ClickForgotPasswordButton()
                .VerifyForgotPasswordButton();
        }
    }
}

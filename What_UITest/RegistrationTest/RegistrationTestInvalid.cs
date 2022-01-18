using NUnit.Framework;
using What_Common.Resources;
using What_PageObject.RegistrationPage;

namespace What_UITest.RegistrationTest
{
    internal class RegistrationTestInvalid : BaseTest
    {
        private RegistrationPage registrationPage;
        [SetUp]
        public void Setup()
        {
            registrationPage = new RegistrationPage()
                  .ClickRegistrationButton(Locators.RegistrationPage.Registration);
        }

        [Test]
        public void UnnasignedUserCantRegister()
        {
            registrationPage.FillFirstName(Resources.empty)
            .FillLastName(Resources.empty)
            .VerifyErrorMassage(Resources.ErrorFieldName)
            .FillEmailAdress(Resources.empty)
            .VerifyErrorMassage(Resources.ErrorFieldName)
            .FillPassword(Resources.empty)
            .VerifyErrorMassage(Resources.ErrorFieldName)
            .FillConfirmPassword(Resources.empty)
            .VerifyErrorMassage(Resources.ErrorFieldName);
        }
    }
}

using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.Objects.ForgotPassword;

namespace What_APITest.API_Tests.ForgotPasswordTests
{
    [AllureNUnit]
    [TestFixture]
    public class POST_ForgotPassword_BadRequest : BaseTest
    {
        [Test(Description = "ForgotPasswordTests")]
        [AllureTag("APITests")]
        [AllureSuite("ForgotPassword")]
        [AllureSubSuite("POST")]
        public void VerifySendingChangePasswordRequest_BadRequest()
        {
            ForgotPasswordObject forgotPasswordObjest = new ForgotPasswordObject(null);
            forgotPasswordObjest.VerifyForgotPasswordRequest_BadRequest();
        }
    }
}
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.Objects.ForgotPassword;

namespace What_APITest.API_Tests.ForgotPasswordTests
{
    [AllureNUnit]
    [TestFixture]
    public class Success : BaseTest
    {
        [Test(Description = "ForgotPasswordTests")]
        [AllureTag("APITests")]
        [AllureSuite("ForgotPassword")]
        [AllureSubSuite("POST")]
        public void VerifySendingChangePasswordRequest_Success()
        {
            ForgotPasswordObject forgotPasswordObjest = new ForgotPasswordObject(null);
            forgotPasswordObjest.VerifyForgotPasswordRequest_Success();
        }
    }
}
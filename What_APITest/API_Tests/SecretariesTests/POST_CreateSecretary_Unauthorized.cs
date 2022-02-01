using NUnit.Framework;
using System;
using What_Common.DataProvider;
using What_APIObject;
using What_APIObject.Objects.Secretaries;
using What_APIObject.Entities.Accounts;
using What_Common.Utils;
using NUnit.Allure.Core;
using NUnit.Allure.Attributes;
using Allure.Commons;
using What_Common.Resources;
using System.Net;

// pass!

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]

    public class POST_CreateSecretary_Unauthorized : BaseTest
    {
        [Test(Description = "SecretariesTests")]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("POST")]
        public void VerifyCreateSecretary_Unauthorized()
        {
            AccountUser secretaryAccount;
            SecretariesObject secretariesObject = new SecretariesObject(null);
            secretariesObject.RegistrationNewUser(out secretaryAccount);
            secretariesObject.VerifyCreateNewSecretary(secretaryAccount, HttpStatusCode.Unauthorized);
        }
    }
}
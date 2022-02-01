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

// in process... what get status "Unauthorized"?

namespace What_APITest.API_Tests.SecretariesTests
{
    [AllureNUnit]
    [TestFixture]
    public class GET_GetAllSecretaries_Unauthorized : BaseTest
    {
        SecretariesObject secretariesObject;
        SecretariesObject secretariesObject2;

        [Test(Description = "SecretariesTests")]
        [AllureTag("APITests")]
        [AllureSuite("Secretaries")]
        [AllureSubSuite("GET")]
        public void VerifyGetAllSecretaries_Unauthorized()
        {
            //VerifyGetAllSecretaries(HttpStatusCode.Unauthorized);
        }

        [TearDown]
        public void After()
        {
            secretariesObject.DisableSecretary();
        }
    }
}
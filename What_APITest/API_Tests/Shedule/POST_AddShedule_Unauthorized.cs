using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.API_Object.Shedule;

namespace What_APITest.API_Tests.Shedule
{
    [AllureNUnit]
    public class POST_AddShedule_Unauthorized : BaseTest
    {
        private GetAllShedule shedule;

        [SetUp]
        public void Setup()
        {
            shedule = new GetAllShedule(null);
        }

        [Test]
        [AllureTag("APITests")]
        [AllureSuite("Shedule")]
        [AllureSubSuite("POST")]
        public void SheduleTest()
        {
            shedule.GenerateDataForShedule()
                   .CreateNewShedule()
                   .VerifyShedulesUnauthorized();
        }
    }
}
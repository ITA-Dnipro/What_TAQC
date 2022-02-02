using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.API_Object.Shedule;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.Shedule
{
    [AllureNUnit]
    public class GET_AddSheduleById_Unauthorized : BaseTest
    {
        private LoginDetails user;
        private GetAllShedule shedule;

        [SetUp]
        public void Setup()
        {
            user = Controller.GetUser(Controller.UserRole.Mentor);
            var role = Controller.UserRole.Mentor.ToString().ToLower();

            shedule = new GetAllShedule(null);
        }

        [Test]
        [AllureTag("APITests")]
        [AllureSuite("Shedule")]
        [AllureSubSuite("GET")]
        public void SheduleTest()
        {
            shedule.GenerateDataForShedule()
                   .VerifyShedulesUnauthorized();
        }
    }
}
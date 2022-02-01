using NUnit.Framework;
using What_APIObject.API_Object.Shedule;

namespace What_APITest.API_Tests.Shedule
{
    public class POST_AddSheduleUnauthorized : BaseTest
    {
        private GetAllShedule shedule;

        [SetUp]
        public void Setup()
        {
            shedule = new GetAllShedule(null);
        }

        [Test]
        public void SheduleTest()
        {
            shedule.GenerateDataForShedule()
                   .CreateNewShedule()
                   .VerifyShedulesUnauthorized();
        }
    }
}
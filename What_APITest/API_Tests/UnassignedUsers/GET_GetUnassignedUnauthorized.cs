using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APITest.API_Object.UnassignedUsers;

namespace What_APITest.API_Tests.UnassignedUsers
{
    [AllureNUnit]
    public class GET_GetUnassignedUnauthorized : BaseTest
    {
        private GetAllUnassignedUsers users;

        [SetUp]
        public void Setup()
        {
            users = new GetAllUnassignedUsers(null);
        }

        [Test]
        [AllureTag("APITests")]
        [AllureSuite("UnassignedUsers")]
        [AllureSubSuite("GET")]
        public void GetAllUnassignedTest()
        {
            users.GenerateNewUser()
                 .CreateUserInSystem()
                 .VerifyUserUnauthorized();
        }
    }
}
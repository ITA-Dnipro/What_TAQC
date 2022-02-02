using NUnit.Framework;
using What_APITest.API_Object.UnassignedUsers;

namespace What_APITest.API_Tests.UnassignedUsers
{
    public class GET_GetUnassignedUnauthorized : BaseTest
    {
        private GetAllUnassignedUsers users;

        [SetUp]
        public void Setup()
        {
            users = new GetAllUnassignedUsers(null);
        }

        [Test]
        public void GetAllUnassignedTest()
        {
            users.GenerateNewUser()
                 .CreateUserInSystem()
                 .VerifyUserUnauthorized();
        }
    }
}
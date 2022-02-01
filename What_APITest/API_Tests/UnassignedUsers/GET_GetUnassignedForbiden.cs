using NUnit.Framework;
using What_APIObject.Entities.Accounts;
using What_APITest.API_Object.UnassignedUsers;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.UnassignedUsers
{
    public class GET_GetUnassignedForbiden : BaseTest
    {
        private GetAllUnassignedUsers users;
        private LoginDetails user;

        [SetUp]
        public void Setup()
        {
            user = Controller.GetUser(Controller.UserRole.Admin);
            var role = Controller.UserRole.Admin.ToString().ToLower();
            users = new GetAllUnassignedUsers(new User { Email = "william.davies@example.com", Password = "Mm_l201R", Role = "mentor" });
        }

        [Test]
        public void GetAllUnassignedTest()
        {
            users.VerifyUserForbiden();
        }
    }
}
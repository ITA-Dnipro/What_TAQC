using NUnit.Framework;
using What_APIObject.Entities.Accounts;
using What_APITest.API_Object.UnassignedUsers;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.UnassignedUsers
{
    public class GET_GetUnassignedSuccess : BaseTest
    {
        private GetAllUnassignedUsers users;
        private LoginDetails user;

        [SetUp]
        public void Setup()
        {
            user = Controller.GetUser(Controller.UserRole.Admin);
            var role = Controller.UserRole.Admin.ToString().ToLower();
            users = new GetAllUnassignedUsers(new User { Email = user.Email, Password = user.Password, Role = role });
        }

        [Test]
        public void GetAllUnassignedTest()
        {
            users.GenerateNewUser()
                 .CreateUserInSystem()
                 .VerifyUsersCreate();
        }
    }
}
using NUnit.Framework;
using What_APITest.API_Object.UnassignedUsers;
using What_APITest.Entities.Accounts;
using What_Common.DataProvider;
using What_Common.Utils;

namespace What_APITest.API_Tests.UnassignedUsers
{
    public class GetUnassigned : API_BaseTest
    {
        private GetAllUnassignedUsers users;
        private RegistredUser newUser;
        private LoginDetails user;

        [SetUp]
        public void Setup()
        {
            user = Controller.GetUser(Controller.UserRole.Admin);
            var role = Controller.UserRole.Admin.ToString().ToLower();

            users = new GetAllUnassignedUsers(new User { Email = user.Email, Password = user.Password, Role =  role});

            newUser = new RegistredUser
            {
                FirstName = StringGenerator.GenerateString(10),
                LastName = StringGenerator.GenerateString(10),
                Email = StringGenerator.GenerateEmailString,
                Password = "Qwerty_123",
                ConfirmPassword = "Qwerty_123"
            };
        }

        [Test]
        public void GetAllUnassignedTest()
        {
            users.CreateUserInSystem(newUser)
                 .VerifyGetAllUnassignedUser()
                 .VerifyUsersCreate(newUser);
        }

        [Test]
        public void GetAllUnassignedTests()
        {
            users.CreateUserInSystem(newUser)
                 .VerifyGetAllUnassignedUser()
                 .VerifyUsersCreate(newUser);
        }
    }
}

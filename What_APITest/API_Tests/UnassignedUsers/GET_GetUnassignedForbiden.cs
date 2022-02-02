using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using What_APIObject.Entities.Accounts;
using What_APITest.API_Object.UnassignedUsers;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.UnassignedUsers
{
    [AllureNUnit]

    public class GET_GetUnassignedForbiden : BaseTest
    {
        private GetAllUnassignedUsers users;
        private LoginDetails user;

        [SetUp]
        public void Setup()
        {
            user = Controller.GetUser(Controller.UserRole.Mentor);
            var role = Controller.UserRole.Mentor.ToString().ToLower();
            users = new GetAllUnassignedUsers(new User { Email = user.Email, Password = user.Password, Role = role });
        }

        [Test]
        [AllureTag("APITests")]
        [AllureSuite("UnassignedUsers")]
        [AllureSubSuite("GET")]

        public void GetAllUnassignedTest()
        {
            users.VerifyUserForbiden();
        }
    }
}
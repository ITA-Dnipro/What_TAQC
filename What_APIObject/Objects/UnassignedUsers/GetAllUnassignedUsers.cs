using NUnit.Framework;
using System.Net;
using What_APIObject;
using What_APIObject.Entities.Accounts;
using What_APITest.Entities.Accounts;
using What_Common.Resources;
using What_Common.Utils;

namespace What_APITest.API_Object.UnassignedUsers
{
    public class GetAllUnassignedUsers
    {
        private WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;
        private RegisterUser newUser;
        private AccountUser user;

        public GetAllUnassignedUsers(User user)
        {
            client = new WHATClient(user);
        }

        public GetAllUnassignedUsers GenerateNewUser()
        {
            var password = StringGenerator.GeneratePassword(new Random().Next(8, 16));

            newUser = new RegisterUser
            {
                FirstName = StringGenerator.GenerateString(new Random().Next(5, 20)),
                LastName = StringGenerator.GenerateString(new Random().Next(5, 20)),
                Email = StringGenerator.GenerateEmail(),
                Password = password,
                ConfirmPassword = password
            };

            return this;
        }

        public GetAllUnassignedUsers CreateUserInSystem()
        {
            uri = new Uri(Endpoints.Accounts.accountsReg, UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, newUser, out statusCode);
            user = response;

            return this;
        }

        public GetAllUnassignedUsers VerifyUsersCreate()
        {
            uri = new Uri(Endpoints.Accounts.accountsNotAssigned, UriKind.Relative);
            var response = client.Get<List<AccountNotAssigned>>(uri, out statusCode);
            var createdUnassigned = response.Find(u => u.Id == user.Id);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(HttpStatusCode.OK, statusCode);
                Assert.AreEqual(createdUnassigned.FirstName, user.FirstName);
                Assert.AreEqual(createdUnassigned.LastName, user.LastName);
                Assert.AreEqual(createdUnassigned.Email, user.Email);
                Assert.AreEqual(createdUnassigned.Role, 0);
            });

            return this;
        }

        public GetAllUnassignedUsers VerifyUserForbiden()
        {
            uri = new Uri(Endpoints.Accounts.accountsNotAssigned, UriKind.Relative);
            var response = client.Get<List<AccountNotAssigned>>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.Forbidden, statusCode);

            return this;
        }

        public GetAllUnassignedUsers VerifyUserUnauthorized()
        {
            uri = new Uri(Endpoints.Accounts.accountsNotAssigned, UriKind.Relative);
            var response = client.Get<List<AccountNotAssigned>>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.Unauthorized, statusCode);

            return this;
        }
    }
}
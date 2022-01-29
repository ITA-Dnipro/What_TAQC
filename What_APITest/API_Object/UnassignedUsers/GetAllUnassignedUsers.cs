using NUnit.Framework;
using System;
using System.Net;
using What_APITest.Entities.Accounts;

namespace What_APITest.API_Object.UnassignedUsers
{
    internal class GetAllUnassignedUsers
    {
        private WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;

        public GetAllUnassignedUsers(User user)
        {
            client = new WHATClient(user);
        }

        public GetAllUnassignedUsers CreateUserInSystem(RegistredUser newUser)
        {
            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegistredUser, AccountUser>(uri, newUser, out statusCode);

            return this;
        }

        public GetAllUnassignedUsers VerifyGetAllUnassignedUser()
        {
            uri = new Uri($"/api/v2/accounts/NotAssigned", UriKind.Relative);
            var response = client.Get<AccountNotAssigned>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return this;
        }

        public GetAllUnassignedUsers VerifyUsersCreate(RegistredUser user)
        {
            uri = new Uri($"/api/v2/accounts/NotAssigned", UriKind.Relative);
            var response = client.Get(uri);
            //var unassignedList = JsonConvert.DeserializeObject<List<AccountNotAssigned>>(response);
            //var createdUnassigned = unassignedList.Find(u => u.Email == user.Email);

            //Assert.Multiple(() =>
            //{
            //    Assert.AreEqual(createdUnassigned.FirstName, user.FirstName);
            //    Assert.AreEqual(createdUnassigned.LastName, user.LastName);
            //    Assert.AreEqual(createdUnassigned.Email, user.Email);
            //});

            return this;
        }
    }
}

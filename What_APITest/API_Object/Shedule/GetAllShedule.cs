using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Net;
using What_APITest.Entities.Accounts;
using What_APITest.Entities.Shedule;

namespace What_APITest.API_Object.Shedule
{
    internal class GetAllShedule
    {
        private WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;

        public GetAllShedule(User user)
        {
            client = new WHATClient(user);
        }

        public GetAllShedule CreateNewShedule(Shedules newShedule)
        {
            uri = new Uri($"/api/v2/schedules", UriKind.Relative);
            var response = client.Post<Shedules, Shedules>(uri, newShedule, out statusCode);

            return this;
        }

        public GetAllShedule VerifyGetAllUnassignedUser()
        {
            uri = new Uri($"/api/v2/accounts/NotAssigned", UriKind.Relative);
            var response = client.Get<AccountNotAssigned>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return this;
        }

        public GetAllShedule VerifyUsersCreate(RegistredUser user)
        {
            uri = new Uri($"/api/v2/accounts/NotAssigned", UriKind.Relative);
            var response = client.Get(uri);
            var unassignedList = JsonConvert.DeserializeObject<List<AccountNotAssigned>>(response);
            var createdUnassigned = unassignedList.Find(u => u.Email == user.Email);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(createdUnassigned.FirstName, user.FirstName);
                Assert.AreEqual(createdUnassigned.LastName, user.LastName);
                Assert.AreEqual(createdUnassigned.Email, user.Email);
            });

            return this;
        }
    }
}

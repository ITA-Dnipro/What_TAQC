using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using System.Text.Json.Nodes;
using What_APIObject;
using What_APIObject.Entities.Accounts;
using What_Common.Utils;

namespace What_APITest
{
    public class RegistrationObject
    {
        WHATClient client;
        Uri uri;
        HttpStatusCode statusCode;
        AccountUser accountUser;

        public RegistrationObject(User user)
        {
            client = new WHATClient(user);  
        }

        public RegisterUser CreateUser()
        {
            RegisterUser user = new RegisterUser();
            user.FirstName = StringGenerator.GenerateString(new Random().Next(2, 30));
            user.LastName = StringGenerator.GenerateString(new Random().Next(2, 30));
            user.Email = StringGenerator.GenerateEmail;
            user.Password = StringGenerator.GeneratePassoword(new Random().Next(8, 16));
            user.ConfirmPassword = user.Password;
            return user;
        }
        public RegistrationObject AddNewUser()
        {
            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            accountUser = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
        public RegistrationObject VerifyRegistration()
        {
            uri = new Uri($"/api/v2/accounts/NotAssigned", UriKind.Relative);
            var response = client.Get(uri, out statusCode);
            var unassignedUserList = JsonConvert.DeserializeObject<List<AccountUser>>(response);
            var unassignedUser = unassignedUserList.Find(s=>s.Id == accountUser.Id);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(HttpStatusCode.OK, statusCode);
                Assert.AreEqual(unassignedUser.Id, accountUser.Id);
                Assert.AreEqual(unassignedUser.FirstName, accountUser.FirstName);
                Assert.AreEqual(unassignedUser.LastName, accountUser.LastName);
                Assert.AreEqual(unassignedUser.Email, accountUser.Email);
            });
            return this;
        }

    }
}

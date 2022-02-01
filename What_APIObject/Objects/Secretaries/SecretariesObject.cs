using System.Net;
using What_APIObject;
using NUnit.Framework;
using Newtonsoft.Json;
using What_APIObject.Entities.Accounts;
using What_APIObject.Entities.Secretaries;
using What_Common.Utils;

namespace What_APITest.Objects.Secretaries
{
    public class SecretariesObject
    {
        WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;
        AccountUser accountUser;

        public SecretariesObject(User user)
        {
             client = new WHATClient(user);
        }

        public SecretariesObject GetAllSecretaries()
        {
            uri = new Uri($"/api/v2/secretaries", UriKind.Relative);
            var response = client.Get<SecretariesModel>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        public SecretariesObject VerifyExistSecretary()
        {
            uri = new Uri($"/api/v2/secretaries", UriKind.Relative);
            var response = client.Get<List<SecretariesModel>>(uri, out statusCode);
            var secretary = response.Find(s => s.Id == accountUser.Id);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(HttpStatusCode.OK, statusCode);
                Assert.AreEqual(secretary.Id, accountUser.Id);
                Assert.AreEqual(secretary.FirstName, accountUser.FirstName);
                Assert.AreEqual(secretary.LastName, accountUser.LastName);
                Assert.AreEqual(secretary.Email, accountUser.Email);
            });
            return this;
        }

        public RegisterUser CreateUser()
        {
            RegisterUser user = new RegisterUser();
            user.FirstName = StringGenerator.GenerateString(new Random().Next(2, 30));
            user.LastName = StringGenerator.GenerateString(new Random().Next(2, 30));
            user.Email = StringGenerator.GenerateEmail();
            user.Password = StringGenerator.GeneratePassword(new Random().Next(8, 16));
            user.ConfirmPassword = user.Password;
            return user;
        }

        public SecretariesObject RegistrationNewUser()
        {
            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            accountUser = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        public SecretariesObject CreateNewSecretary()
        {
            uri = new Uri($"/api/v2/secretaries/{accountUser.Id}", UriKind.Relative);
            var response = client.Post<AccountUser>(uri, out statusCode);
            accountUser = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        public SecretariesObject DisableSecretary()
        {
            uri = new Uri($"/api/v2/secretaries/{accountUser.Id}", UriKind.Relative);
            var response = client.Delete<List<SecretariesModel>>(uri, out statusCode);
            //Assert.IsTrue(response.Contains("true"));
            return this;
        }

        public SecretariesObject VerifyDisableSecretary()
        {
            uri = new Uri($"/api/v2/secretaries/{accountUser.Id}", UriKind.Relative);
            var response = client.Delete<List<SecretariesModel>>(uri, out statusCode);
            //Assert.IsTrue(response.Contains("true"));
            return this;
        }
    }
}

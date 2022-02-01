using System.Net;
using What_APIObject;
using NUnit.Framework;
using Newtonsoft.Json;
using What_APIObject.Entities.Accounts;
using What_APIObject.Entities.Secretaries;
using What_Common.Utils;
using What_Common.Resources;

namespace What_APIObject.Objects.Secretaries
{
    public class SecretariesObject
    {
        public WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;
        AccountUser accountUser;

        public SecretariesObject(User user)
        {
            client = new WHATClient(user);
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
            uri = new Uri(Endpoints.Accounts.accountsReg, UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            accountUser = response;
            return this;
        }

        public SecretariesObject CreateNewSecretary()
        {
            uri = new Uri(Endpoints.Secretaries.SecretariesByAccountId(accountUser.Id.ToString()), UriKind.Relative);
            var response = client.Post<AccountUser>(uri, out statusCode);
            accountUser = response;
            return this;
        }

        public SecretariesObject DisableSecretary()
        {
            uri = new Uri(Endpoints.Secretaries.SecretariesByAccountId(accountUser.Id.ToString()), UriKind.Relative);
            var response = client.Delete(uri, out statusCode);
            return this;
        }

        #region Verifications

        public SecretariesObject VerifyGetAllSecretaries(HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Secretaries.secretaries, UriKind.Relative);
            var response = client.Get<List<SecretariesModel>>(uri, out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                //var secretaryList = JsonConvert.DeserializeObject<List<SecretariesModel>>(response);
                //var secretary = secretaryList.Find(s => s.Id == accountUser.Id);
                var secretary = response.Find(s => s.Id == accountUser.Id);
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                    Assert.AreEqual(secretary.Id, accountUser.Id);
                    Assert.AreEqual(secretary.FirstName, accountUser.FirstName);
                    Assert.AreEqual(secretary.LastName, accountUser.LastName);
                    Assert.AreEqual(secretary.Email, accountUser.Email);
                });
            }
            else
            {
                Assert.AreEqual(expectedStatusCode, statusCode);
            }
            return this;
        }

        public SecretariesObject VerifyGetActiveSecretaries(HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Secretaries.secretariesActive, UriKind.Relative);
            var response = client.Get<List<SecretariesModel>>(uri, out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                //var secretaryList = JsonConvert.DeserializeObject<List<SecretariesModel>>(response);
                //var secretary = secretaryList.Find(s => s.Id == accountUser.Id);
                var secretary = response.Find(s => s.Id == accountUser.Id);
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                    Assert.AreEqual(secretary.Id, accountUser.Id);
                    Assert.AreEqual(secretary.FirstName, accountUser.FirstName);
                    Assert.AreEqual(secretary.LastName, accountUser.LastName);
                    Assert.AreEqual(secretary.Email, accountUser.Email);
                });
            }
            else
            {
                Assert.AreEqual(expectedStatusCode, statusCode);
            }
            return this;
        }

        public SecretariesObject VerifyCreateNewSecretary(HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Secretaries.SecretariesByAccountId(accountUser.Id.ToString()), UriKind.Relative);
            var response = client.Post<AccountUser>(uri, out statusCode);
            if(expectedStatusCode == HttpStatusCode.OK)
            {
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                    Assert.AreEqual(response.FirstName, accountUser.FirstName);
                    Assert.AreEqual(response.LastName, accountUser.LastName);
                    Assert.AreEqual(response.Email, accountUser.Email);
                });
            }
            else
            {
                Assert.AreEqual(expectedStatusCode, statusCode);
            }
            return this;
        }

        public SecretariesObject VerifyDisableSecretary(HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Secretaries.SecretariesByAccountId(accountUser.Id.ToString()), UriKind.Relative);
            var response = client.Delete(uri, out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                    Assert.IsTrue(response.Contains("true"));
                });
            }
            else
            {
                Assert.AreEqual(expectedStatusCode, statusCode);
            }
            return this;
        }

        #endregion
    }
}

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
        SecretariesModel accountSecretary;

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

        public AccountUser RegistrationNewUser(out AccountUser user)
        {
            uri = new Uri(Endpoints.Accounts.accountsReg, UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            user = response;
            accountUser = user;
            return user;
        }

        public SecretariesObject CreateNewSecretary(AccountUser user, out SecretariesModel accountSecretary)
        {
            uri = new Uri(Endpoints.Secretaries.SecretariesByAccountId(user.Id.ToString()), UriKind.Relative);
            var response = client.Post<SecretariesModel>(uri, out statusCode);
            accountSecretary = response;
            return this;
        }

        public SecretariesModel CreateSecretaryToUpdate()
        {
            SecretariesModel secretary = new SecretariesModel()
            {
                FirstName = StringGenerator.GenerateString(new Random().Next(2, 30)),
                LastName = StringGenerator.GenerateString(new Random().Next(2, 30)),
                Email = StringGenerator.GenerateEmail()
            };
            return secretary;
        }

        public SecretariesObject DisableSecretary(SecretariesModel user)
        {
            uri = new Uri(Endpoints.Secretaries.SecretariesByAccountId(user.Id.ToString()), UriKind.Relative);
            var response = client.Delete<SecretariesModel>(uri, out statusCode);
            return this;
        }

        #region Verifications

        public SecretariesObject VerifyGetAllSecretaries(SecretariesModel user, HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Secretaries.secretaries, UriKind.Relative);
            var response = client.Get<List<SecretariesModel>>(uri, out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                var secretary = response.Find(s => s.Id == user.Id);
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                    Assert.AreEqual(secretary.Id, user.Id);
                    Assert.AreEqual(secretary.FirstName, user.FirstName);
                    Assert.AreEqual(secretary.LastName, user.LastName);
                    Assert.AreEqual(secretary.Email, user.Email);
                });
            }
            else
            {
                Assert.AreEqual(expectedStatusCode, statusCode);
            }
            return this;
        }

        public SecretariesObject VerifyGetActiveSecretaries(SecretariesModel user, HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Secretaries.secretariesActive, UriKind.Relative);
            var response = client.Get<List<SecretariesModel>>(uri, out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                var secretary = response.Find(s => s.Id == user.Id);
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                    Assert.AreEqual(secretary.Id, user.Id);
                    Assert.AreEqual(secretary.FirstName, user.FirstName);
                    Assert.AreEqual(secretary.LastName, user.LastName);
                    Assert.AreEqual(secretary.Email, user.Email);
                });
            }
            else
            {
                Assert.AreEqual(expectedStatusCode, statusCode);
            }
            return this;
        }

        public SecretariesObject VerifyCreateNewSecretary(AccountUser user, HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Secretaries.SecretariesByAccountId(user.Id.ToString()), UriKind.Relative);
            var response = client.Post<SecretariesModel>(uri, out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                    Assert.AreEqual(response.FirstName, user.FirstName);
                    Assert.AreEqual(response.LastName, user.LastName);
                    Assert.AreEqual(response.Email, user.Email);
                });
                DisableSecretary(response);
            }
            else
            {
                Assert.AreEqual(expectedStatusCode, statusCode);
            }
            return this;
        }

        public SecretariesObject VerifyDisableSecretary(SecretariesModel user, HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Secretaries.SecretariesByAccountId(user.Id.ToString()), UriKind.Relative);
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

        public SecretariesObject VerifyUpdateSecretary(SecretariesModel user, HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Secretaries.SecretariesById(user.Id.ToString()), UriKind.Relative);
            var response = client.Put<SecretariesModel, SecretariesModel>(uri, CreateSecretaryToUpdate(), out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode);
                    Assert.AreEqual(response.Id, user.Id);
                    Assert.AreNotEqual(response.FirstName, user.FirstName);
                    Assert.AreNotEqual(response.LastName, user.LastName);
                    Assert.AreNotEqual(response.Email, user.Email);
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

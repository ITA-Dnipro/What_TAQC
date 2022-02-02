using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using What_APIObject.Entities.Accounts;
using What_Common.Utils;
using What_Common.Resources;

namespace What_APIObject.Objects.Mentors
{
    public class MentorObject
    {
        WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;
        AccountUser accountUser;
        List<AccountUser> response;
        
        public MentorObject(User user)
        {
            client = new WHATClient(user);
        }
       

        public MentorObject GetAllMentors()
        {
            uri = new Uri(Endpoints.Mentors.mentors, UriKind.Relative);
            response = client.Get<List<AccountUser>>(uri, out statusCode);
            return this;
        }

        public MentorObject VerifyGetAllMentors()
        {
            var mentorsList = response.Find(s => s.Id == accountUser.Id);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
        public MentorObject GetActiveMentors()
        {
            uri = new Uri(Endpoints.Mentors.mentorsActive, UriKind.Relative);
            response = client.Get<List<AccountUser>>(uri, out statusCode);
            return this;
        }

        public MentorObject VerifyGetActiveMentors()
        {
            
            var mentor = response.Find(s => s.Id == accountUser.Id);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(HttpStatusCode.OK, statusCode);
                Assert.AreEqual(mentor.Id, accountUser.Id);
                Assert.AreEqual(mentor.FirstName, accountUser.FirstName);
                Assert.AreEqual(mentor.LastName, accountUser.LastName);
                Assert.AreEqual(mentor.Email, accountUser.Email);
            });
            return this;
        }
        public MentorObject VerifyGetMentorNotFound()
        {
            Assert.AreEqual(HttpStatusCode.NotFound, statusCode);
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
        public MentorObject RegistrationNewUser()
        {
            uri = new Uri(Endpoints.Accounts.accountsReg,UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            accountUser = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
        public MentorObject CreateNewMentor()
        {
            uri = new Uri(Endpoints.Mentors.MentorsByAccountId(accountUser.Id), UriKind.Relative);
            var response = client.Post<AccountUser>(uri, out statusCode);
            accountUser = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
        public MentorObject VerifyGetMentorById()
        {
            uri = new Uri(Endpoints.Mentors.MentorById(accountUser.Id),UriKind.Relative);
            var response = client.Get<AccountUser>(uri, out statusCode);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(HttpStatusCode.OK, statusCode);
                Assert.AreEqual(response.Id, accountUser.Id);
                Assert.AreEqual(response.FirstName, accountUser.FirstName);
                Assert.AreEqual(response.LastName, accountUser.LastName);
                Assert.AreEqual(response.Email, accountUser.Email);
            });
            return this;
        }
        public MentorObject VerifyGetMentorIdNotFound()
        {
            uri = new Uri(Endpoints.Mentors.MentorById(accountUser.Id), UriKind.Relative);
            var response = client.Get<AccountUser>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.NotFound, statusCode);
            return this;
        }
        public MentorObject VerifyDeleteMentorById()
        {
            uri = new Uri(Endpoints.Mentors.MentorById(accountUser.Id), UriKind.Relative);
            var response = client.Delete<AccountUser>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
    }
}

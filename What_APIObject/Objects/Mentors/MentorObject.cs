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

namespace What_APIObject.Objects.Mentors
{
    public class MentorObject
    {
        WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;
        AccountUser accountUser;
        string response;
        public MentorObject(User user)
        {
            client = new WHATClient(user);
        }
       

        public MentorObject GetAllMentors()
        {
            uri = new Uri($"/api/v2/mentors", UriKind.Relative);
            response = client.Get(uri, out statusCode);            
            return this;
        }

        public MentorObject VerifyGetAllMentors()
        {
            var mentorsList = JsonConvert.DeserializeObject<List<AccountUser>>(response);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
        public MentorObject GetMentor()
        {
            uri = new Uri($"/api/v2/mentors/{accountUser.Id}", UriKind.Relative);
            response = client.Get(uri, out statusCode);
            return this;
        }

        public MentorObject VerifyGetMentor()
        {           
            var mentor = JsonConvert.DeserializeObject<AccountUser>(response);          
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

        public MentorObject VerifyGetMentorForbidden()
        {
            Assert.AreEqual(HttpStatusCode.Forbidden, statusCode);
            return this;
        }

        public MentorObject PutInformationMentor()
        {
            uri = new Uri($"/api/v2/mentors/{accountUser.Id}", UriKind.Relative);
            var response = client.Put<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
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
        public MentorObject RegistrationNewUser()
        {
            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            accountUser = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
        public MentorObject CreateNewMentor()
        {
            uri = new Uri($"/api/v2/mentors/{accountUser.Id}", UriKind.Relative);
            var response = client.Post<AccountUser>(uri, out statusCode);
            accountUser = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
    }
}

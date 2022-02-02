using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using What_APIObject.Entities.Accounts;
using What_APIObject.Entities.Students;
using What_Common.Resources;
using What_Common.Utils;

namespace What_APIObject.Objects.Students
{
    public class StudentsObject
    {
        #region Messages
        public const string HttpStatusCodeMessage = "Http Status Code";
        public const string StudentIdMessage = "Student Id";
        public const string StudentIdFirstNameMessage = "First Name";
        public const string StudentIdLastNameMessage = "Last Name";
        public const string StudentIdEmailMessage = "Email";
        #endregion

        public WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;
        AccountUser accountUser;

        public StudentsObject(User user)
        {
            client = new WHATClient(user);
        }

        #region StudentManagement
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

        public StudentsObject RegisterNewUser()
        {
            uri = new Uri(Endpoints.Accounts.accountsReg, UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            accountUser = response;
            return this;
        }

        public StudentsObject CreateNewStudent()
        {
            uri = new Uri(Endpoints.Students.StudentByAccountId(accountUser.Id.ToString()), UriKind.Relative);
            var response = client.Post<AccountUser>(uri, out statusCode);
            accountUser = response;
            return this;
        }

        public StudentsObject DisableStudent()
        {
            uri = new Uri(Endpoints.Students.StudentByAccountId(accountUser.Id.ToString()), UriKind.Relative);
            var response = client.Delete(uri, out statusCode);
            return this;
        }
        #endregion

        #region StudentAsserts
        public StudentsObject VerifyGetAllStudents(HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Students.students, UriKind.Relative);
            var response = client.Get<List<StudentsModel>>(uri, out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                var student = response.Find(s => s.Id == accountUser.Id);
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(student.Id, accountUser.Id, StudentIdMessage);
                    Assert.AreEqual(student.FirstName, accountUser.FirstName, StudentIdFirstNameMessage);
                    Assert.AreEqual(student.LastName, accountUser.LastName, StudentIdLastNameMessage);
                    Assert.AreEqual(student.Email, accountUser.Email, StudentIdEmailMessage);
                });
            }
            Assert.AreEqual(expectedStatusCode, statusCode, HttpStatusCodeMessage);
            return this;
        }

        public StudentsObject VerifyGetActiveStudents(HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Students.studentsActive, UriKind.Relative);
            var response = client.Get<List<StudentsModel>>(uri, out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                var student = response.Find(s => s.Id == accountUser.Id);
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(student.Id, accountUser.Id, StudentIdMessage);
                    Assert.AreEqual(student.FirstName, accountUser.FirstName, StudentIdFirstNameMessage);
                    Assert.AreEqual(student.LastName, accountUser.LastName, StudentIdLastNameMessage);
                    Assert.AreEqual(student.Email, accountUser.Email, StudentIdEmailMessage);
                });
            }
            Assert.AreEqual(expectedStatusCode, statusCode, HttpStatusCodeMessage);
            return this;
        }

        public StudentsObject VerifyDisableStudent(HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Students.StudentByAccountId(accountUser.Id.ToString()), UriKind.Relative);
            var response = client.Delete(uri, out statusCode);
            if (expectedStatusCode == HttpStatusCode.OK)
            {
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode, HttpStatusCodeMessage);
                    Assert.IsTrue(response.Contains("true"));
                });
            }
            else
            {
                Assert.AreEqual(expectedStatusCode, statusCode, HttpStatusCodeMessage);
            }
            return this;
        }

        public StudentsObject VerifyCreateNewStudent(HttpStatusCode expectedStatusCode)
        {
            uri = new Uri(Endpoints.Students.StudentByAccountId(accountUser.Id.ToString()), UriKind.Relative);
            var response = client.Post<AccountUser>(uri, out statusCode);
            if(expectedStatusCode == HttpStatusCode.OK)
            {
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode, HttpStatusCodeMessage);
                    Assert.AreEqual(response.FirstName, accountUser.FirstName, StudentIdFirstNameMessage);
                    Assert.AreEqual(response.LastName, accountUser.LastName, StudentIdLastNameMessage);
                    Assert.AreEqual(response.Email, accountUser.Email, StudentIdEmailMessage);
                });
            }
            else
            {
                Assert.AreEqual(expectedStatusCode, statusCode, HttpStatusCodeMessage);
            }
            return this;
        }

        #endregion
    }
}

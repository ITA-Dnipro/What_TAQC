using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using What_APIObject;
using What_APIObject.Entities.Accounts;
using What_APITest.Entities.Groups;

namespace What_APITest.API_Object
{
    public class GroupsAPI_Object
    {
        private WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;

        public GroupsAPI_Object(User user)
        {
            client = new WHATClient(user);
        }

        //public GroupsAPI_Object CreateUserInSystem(RegistredUser newUser)
        //{
        //    uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
        //    var response = client.POST<RegistredUser, AccountUser>(uri, newUser, out statusCode);

        //    return this;
        //}

        public GroupsAPI_Object VerifyGetAllStudentsGroups(DateModel date)
        {
            uri = new Uri($"/api/v2/student_groups", UriKind.Relative);
            var response = client.Get<DateModel, GetStudentsGroups>(uri, date, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            return this;
        }

        public GroupsAPI_Object VerifyGetStudentsGroupsFromDates(PostStudentsGroups postStudentsGroups, out int id) //TODO naming!!
        {


            uri = new Uri($"/api/v2/student_groups", UriKind.Relative);
            var response = client.Get<List<GetStudentsGroups>>(uri, out statusCode);
            var createdGroup = response.Find(u => u.Name == postStudentsGroups.Name);
            id = createdGroup.Id;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(createdGroup.MentorIds, postStudentsGroups.MentorIds);
                Assert.AreEqual(createdGroup.FinishDate.ToString("yyyy-MM-dd"), postStudentsGroups.FinishDate.ToString("yyyy-MM-dd"));
                Assert.AreEqual(createdGroup.CourseId, postStudentsGroups.CourseId);
                Assert.AreEqual(createdGroup.StartDate.ToString("yyyy-MM-dd"), postStudentsGroups.StartDate.ToString("yyyy-MM-dd"));
                Assert.AreEqual(createdGroup.StudentIds, postStudentsGroups.StudentIds);
            });

            return this;
        }

        public GroupsAPI_Object AddGroup(PostStudentsGroups postStudents)
        {

            uri = new Uri($"/api/v2/student_groups", UriKind.Relative);
            var response = client.Post<PostStudentsGroups, PostStudentsGroups>(uri, postStudents, out statusCode);

            return this;

        }

        public GroupsAPI_Object UpdateGroup(PostStudentsGroups postStudents)
        {

            uri = new Uri($"/api/v2/student_groups/{postStudents.Id}", UriKind.Relative);
            var response = client.Put<PostStudentsGroups, PostStudentsGroups>(uri, postStudents, out statusCode);

            return this;

        }

        public GroupsAPI_Object VerifyUpdateInfo(PostStudentsGroups postStudentsGroups, int id) //TODO naming!!
        {


            uri = new Uri($"/api/v2/student_groups", UriKind.Relative);
            var response = client.Get<List<GetStudentsGroups>>(uri, out statusCode);

            var createdGroup = response.Find(u => u.Id == id);


            Assert.Multiple(() =>
            {
                Assert.AreEqual(createdGroup.MentorIds, postStudentsGroups.MentorIds);
                Assert.AreEqual(createdGroup.FinishDate.ToString("yyyy-MM-dd"), postStudentsGroups.FinishDate.ToString("yyyy-MM-dd"));
                Assert.AreEqual(createdGroup.CourseId, postStudentsGroups.CourseId);
                Assert.AreEqual(createdGroup.StartDate.ToString("yyyy-MM-dd"), postStudentsGroups.StartDate.ToString("yyyy-MM-dd"));
                Assert.AreEqual(createdGroup.StudentIds, postStudentsGroups.StudentIds);
            });

            return this;
        }
        //public GroupsAPI_Object VerifyUsersCreate(RegistredUser user)
        //{
        //    uri = new Uri($"/api/v2/accounts/NotAssigned", UriKind.Relative);
        //    var response = client.Get(uri);
        //    var unassignedList = JsonConvert.DeserializeObject<List<AccountNotAssigned>>(response);
        //    var createdUnassigned = unassignedList.Find(u => u.Email == user.Email);

        //    Assert.Multiple(() =>
        //    {
        //        Assert.AreEqual(createdUnassigned.FirstName, user.FirstName);
        //        Assert.AreEqual(createdUnassigned.LastName, user.LastName);
        //        Assert.AreEqual(createdUnassigned.Email, user.Email);
        //    });

        //    return this;
        //}


    }
}

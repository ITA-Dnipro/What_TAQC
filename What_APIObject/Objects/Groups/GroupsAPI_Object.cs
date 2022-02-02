﻿using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using What_APIObject;
using What_APIObject.Entities.Accounts;
using What_APITest.Entities.Groups;
using What_Common.Resources;

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

        
        public GroupsAPI_Object VerifyGetAllStudentsGroups(DateModel date)
        {
            uri = new Uri(Endpoints.StudentGroups.studentGroups, UriKind.Relative);
            var response = client.Get<DateModel, GetStudentsGroups>(uri, date, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode,"Assert Equal Fail");

            return this;
        }

        public GroupsAPI_Object VerifyGetAllStudentsGroupsUnauthorized(DateModel date)
        {
            uri = new Uri(Endpoints.StudentGroups.studentGroups, UriKind.Relative);
            var response = client.Get<DateModel, GetStudentsGroups>(uri, date, out statusCode);
            Assert.AreEqual(HttpStatusCode.Unauthorized, statusCode);

            return this;
        }

        
            public GroupsAPI_Object VerifyGetAllStudentsGroupsForbidden (DateModel date)
        {
            uri = new Uri(Endpoints.StudentGroups.studentGroups, UriKind.Relative);
            var response = client.Get<DateModel, GetStudentsGroups>(uri, date, out statusCode);
            Assert.AreEqual(HttpStatusCode.Forbidden, statusCode);

            return this;
        }

        public GroupsAPI_Object VerifyGetStudentsGroupsFromDates(PostStudentsGroups postStudentsGroups, out int id) //TODO naming!!
        {


            uri = new Uri(Endpoints.StudentGroups.studentGroups, UriKind.Relative);
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

            uri = new Uri(Endpoints.StudentGroups.studentGroups, UriKind.Relative);
            var response = client.Post<PostStudentsGroups, PostStudentsGroups>(uri, postStudents, out statusCode);

            return this;

        }

        public GroupsAPI_Object UpdateGroup(PostStudentsGroups postStudents)
        {
            
            uri = new Uri(Endpoints.StudentGroups.StudentGroupsById(postStudents.Id), UriKind.Relative);
            var response = client.Put<PostStudentsGroups, PostStudentsGroups>(uri, postStudents, out statusCode);

            return this;

        }

        public GroupsAPI_Object VerifyUpdateInfo(PostStudentsGroups postStudentsGroups, int id) //TODO naming!!
        {


            uri = new Uri(Endpoints.StudentGroups.studentGroups, UriKind.Relative);
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
        


    }
}

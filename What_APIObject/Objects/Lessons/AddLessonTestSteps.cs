using What_APIObject.Entities.Accounts;
using NUnit.Framework;
using System.Diagnostics;
using System.Net;
using What_APIObject;
using API.Models;

namespace API
{
    public class AddLessonTestSteps
    {
        public WHATClient client;
        Uri uri;
        HttpStatusCode statusCode;

        public Lesson newLessonInSystem;

        public AddLessonTestSteps(User user)
        {
            client = new WHATClient(user);
        }

        public AddLessonTestSteps VerifyGroupExist(int groupId)
        {
            uri = new Uri($"/api/v2/student_groups/{groupId}", UriKind.Relative);
            var response = client.Get<GroupInSystem>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
        public AddLessonTestSteps UpdateLesson(int lessonId, Lesson updatedLesson)
        {
            uri = new Uri($"/api/v2/lessons/{lessonId}", UriKind.Relative);
            var response = client.Put<Lesson, Lesson>(uri, updatedLesson, out statusCode);
            newLessonInSystem = response;

            return this;
        }
        public AddLessonTestSteps VerifyUpdatedLessonExist(Lesson lesson)
        {
            Assert.AreEqual(lesson.ThemeName, newLessonInSystem.ThemeName, "verify");
            return this;
        }

        public AddLessonTestSteps VerifyMentorExist(int mentorId)
        {
            uri = new Uri($"/api/v2/mentors/{mentorId}", UriKind.Relative);
            var response = client.Get<UserInSystem>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        public AddLessonTestSteps VerifyLessonExist(int lessonId)
        {
            uri = new Uri($"/api/v2/lessons/{lessonId}", UriKind.Relative);
            var response = client.Get<Lesson>(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode, message: $"User with role ");
            return this;
        }

        public AddLessonTestSteps AddNewLesson(Lesson newLesson)
        {
            uri = new Uri($"/api/v2/lessons", UriKind.Relative);
            var response = client.Post<Lesson, Lesson>(uri, newLesson, out statusCode);

            newLessonInSystem = response;

            return this;
        }
        public AddLessonTestSteps TryToAddNewLessonWithoutRight(Lesson newLesson)
        {
            uri = new Uri($"/api/v2/lessons", UriKind.Relative);
            var response = client.Post<Lesson, Lesson>(uri, newLesson, out statusCode);

            newLessonInSystem = response;

            return this;
        }
        public AddLessonTestSteps VerifyNewlyAddedLessonNotExist()
        {
            Assert.AreEqual(HttpStatusCode.Forbidden, statusCode, "VerifyNewlyAddedLessonNotExist From Desscription");
            return this;
        }
        public AddLessonTestSteps VerifyNewlyAddedLessonNotExistAuth()
        {
            Assert.AreEqual(HttpStatusCode.Unauthorized, statusCode, "VerifyNewlyAddedLessonNotExist From Desscription");
            return this;
        }
        public AddLessonTestSteps VerifyNewlyAddedLessonExist(Lesson expectedLesson)
        {
            uri = new Uri($"/api/v2/lessons/{newLessonInSystem.Id}", UriKind.Relative);
            var response = client.Get<Lesson>(uri, out statusCode);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(HttpStatusCode.OK, statusCode, "Status code response");
                Assert.AreEqual(expectedLesson.ThemeName, response.ThemeName, "Lessons themes are same ?");
                Assert.AreEqual(expectedLesson.MentorId, response.MentorId, "Mentors are same ?");
            });

            return this;
        }
    }
}

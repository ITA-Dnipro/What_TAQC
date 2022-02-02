using API.Models;
using System.Net;
using What_APIObject;
using What_APIObject.Entities.Accounts;
using What_Common.Utils;

namespace API
{
    public class PreconditionGenerator
    {
        WHATClient client;
        Uri uri;
        HttpStatusCode statusCode;

        public PreconditionGenerator()
        {
            client = new WHATClient(new User { Email = "james.smith@example.com", Password = "Nj_PJ7K9", Role = "admin" });
        }

        public AccountUser RegisterNewUser()
        {
            string password = StringGenerator.GeneratePassword(10);
            RegisterUser newUser = new RegisterUser
            {
                FirstName = StringGenerator.GenerateString(7),
                LastName = StringGenerator.GenerateString(7),
                Email = StringGenerator.GenerateEmail(),
                Password = password,
                ConfirmPassword = password
            };

            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, newUser, out statusCode);

            return response;
        }

        public T AssignNewUserToRole<T>(int accountId, UserRole Role)
            where T : class
        {
            switch (Role)
            {
                case UserRole.Secretary:
                    uri = new Uri($"/api/v2/secretaries/{accountId}", UriKind.Relative);
                    break;
                case UserRole.Mentor:
                    uri = new Uri($"/api/v2/mentors/{accountId}", UriKind.Relative);
                    break;
                case UserRole.Student:
                    uri = new Uri($"/api/v2/students/{accountId}", UriKind.Relative);
                    break;
                default:
                    break;
            }
            var response = client.Post<T>(uri, out statusCode);

            return response;
        }

        public string DisableUser(int accountId, UserRole Role)
        {
            switch (Role)
            {
                case UserRole.Secretary:
                    uri = new Uri($"/api/v2/secretaries/{accountId}", UriKind.Relative);
                    break;
                case UserRole.Mentor:
                    uri = new Uri($"/api/v2/mentors/{accountId}", UriKind.Relative);
                    break;
                case UserRole.Student:
                    uri = new Uri($"/api/v2/students/{accountId}", UriKind.Relative);
                    break;
                default:
                    break;
            }
            var response = client.Delete<String>(uri, out statusCode);

            return response;
        }

        public CourseInSystem CreateNewCourse()
        {
            Course newCourse = new Course { Name = StringGenerator.GenerateString(10) };
            uri = new Uri($"/api/v2/courses", UriKind.Relative);
            var response = client.Post<Course, CourseInSystem>(uri, newCourse, out statusCode);

            return response;
        }

        public CourseInSystem DisableCourse(int courseId)
        {
            uri = new Uri($"/api/v2/courses/{courseId}", UriKind.Relative);
            var response = client.Delete<CourseInSystem>(uri, out statusCode);

            return response;
        }

        public GroupInSystem CreateNewGroup(UserInSystem mentor, List<UserInSystem> students, CourseInSystem course)
        {

            Group group = new Group
            {
                MentorIds = new int[] { mentor.Id },
                Name = StringGenerator.GenerateString(8),
                CourseId = course.Id,
                StudentIds = students.Select( x => x.Id).ToArray(),
                StartDate = "2020-01-25",
                FinishDate = "2022-01-26"
            };

            uri = new Uri($"/api/v2/student_groups", UriKind.Relative);
            var response = client.Post<Group, GroupInSystem>(uri, group, out statusCode);

            return response;
        }
        public Lesson CreateNewLesson(UserInSystem mentor, GroupInSystem studentGroup)
        { 
            Lesson newLesson = new Lesson
            {
                MentorId = mentor.Id,
                StudentGroupId = studentGroup.Id,
                ThemeName = StringGenerator.GenerateString(10),
                LessonDate = StringGenerator.RandomDay(),
                ClassJournal = LessonBuilder.CreateClassBook(studentGroup.StudentIds)
            };

            uri = new Uri($"/api/v2/lessons", UriKind.Relative);
            var response = client.Post<Lesson, Lesson>(uri, newLesson, out statusCode);

            return response;
        }

        public GroupInSystem DeleteGroup(int groupId)
        {
            uri = new Uri($"/api/v2/courses/{groupId}", UriKind.Relative);
            var response = client.Delete<GroupInSystem>(uri, out statusCode);

            return response;
        }
    }

    public enum UserRole
    {
        Secretary = 8,
        Mentor = 2,
        Student = 1
    }
}

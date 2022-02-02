using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using What_APIObject.Entities.Accounts;
using What_APIObject.Entities.Courses;
using What_Common.Utils;
using What_Common.Resources;

namespace What_APIObject.Objects.Courses
{
    public class CourseObject
    {
        public WHATClient client;
        public int courseId;
        private Uri uri;
        private HttpStatusCode statusCode;
        private AccountUser accountUser;
        private CoursesModel courseModel;
        private CoursesPostModel coursePostModel;
        private CoursesGetModel courseGetModel;
        private CoursesPutModel coursePutModel;

        public CourseObject(User user)
        {
            client = new WHATClient(user);
        }

        /// <summary>
        /// Send GET Request and get courses 
        /// </summary>
        /// <param name="isActive">Boolean parametr that check is course active or not. If parametr set as null GET request gives us response with all users</param>
        /// <returns>CourseObject</returns>
        public CourseObject GetCourses(bool? isActive, HttpStatusCode expectedCode)
        {
            uri = new Uri(Endpoints.Courses.courses, UriKind.Relative);
            courseGetModel = new CoursesGetModel();
            courseGetModel.IsActive = isActive;
            var response = client.Get(uri, courseGetModel, out statusCode);
            Assert.AreEqual(expectedCode, statusCode);
            if (expectedCode == HttpStatusCode.OK)
            {
                var courseList = JsonConvert.DeserializeObject<List<CoursesModel>>(response);
                var courses = courseList.Find(s => s.Id == accountUser.Id);
                foreach (var item in courseList)
                {
                    Assert.Multiple(() =>
                    {
                        Assert.IsNotEmpty(item.Id.ToString(), "");
                        Assert.IsNotEmpty(item.Name, "");
                        Assert.IsNotEmpty(item.IsActive.ToString(), "");
                    });
                }
            }
            return this;
        }

        public CourseObject GetCoursesUnauthorized(bool? isActive, HttpStatusCode expectedCode)
        {
            uri = new Uri(Endpoints.Courses.courses, UriKind.Relative);
            courseGetModel = new CoursesGetModel();
            courseGetModel.IsActive = isActive;
            var response = client.Get(uri, courseGetModel, out statusCode);
            Assert.AreEqual(expectedCode, statusCode, "User is Unauthorized (401), otherwise test failed");
            return this;
        }

        public CoursesModel GetCurrentCourse(int id)
        {
            uri = new Uri(Endpoints.Courses.courses, UriKind.Relative);
            var response = client.Get<List<CoursesModel>>(uri, out statusCode);
            var course = response.Find(s => s.Id == id);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(HttpStatusCode.OK, statusCode);
                Assert.AreEqual(course.Id, id);
            });
           
            return course;
        }

        /// <summary>
        /// Send POST request and create new Course
        /// </summary>
        /// <param name="courseName">Name of new course</param>
        /// <param name="valid">If valid true assert check valid values if false invalid values</param>
        /// <returns>CourseObject</returns>
        public CourseObject CreateNewCourse(string courseName, bool valid)
        {
            uri = new Uri(Endpoints.Courses.courses, UriKind.Relative);
            coursePostModel = new CoursesPostModel();
            coursePostModel.Name = courseName;
            var response = client.Post<CoursesPostModel, CoursesModel>(uri, coursePostModel, out statusCode);
            this.courseModel = response;
            if (valid)
            {
                this.courseId = response.Id;
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(HttpStatusCode.OK, statusCode, "Status code must be 200 (OK), otherwise test failed");
                    Assert.That(this.courseModel.Id, Is.Not.Null, "Object contains elements and Id value not null, otherwise test failed");
                    Assert.That(this.courseModel.IsActive, Is.True, "Object contains elements and his value true, otherwise test failed");
                });
            }
            else
            {
                Assert.AreEqual(HttpStatusCode.Forbidden, statusCode, "Status code must be 403 (forbidden), otherwise test failed");
            }

            return this;
        }

        public CourseObject UpdateCourse(int id, string newCourseName)
        {
            uri = new Uri(Endpoints.Courses.CourseById(id.ToString()), UriKind.Relative);
            coursePutModel = new CoursesPutModel();
            coursePutModel.Name = newCourseName;
            var response = client.Put<CoursesPutModel, CoursesModel>(uri, coursePutModel, out statusCode);
            var response_str = response.ToString();
            this.courseModel = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode, "Status code must be 200 (OK), otherwise test failed");
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

        public CourseObject RegistrationNewUser()
        {
            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            accountUser = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        public CourseObject DisableCourse()
        {
            uri = new Uri(Endpoints.Courses.CourseById(courseModel.Id.ToString()), UriKind.Relative);
            var response = client.Delete(uri, out statusCode);
            Assert.IsTrue(response.Contains("false"), "Course is disabled");
            return this;
        }

        public CourseObject EnableCourse(int id)
        {
            uri = new Uri(Endpoints.Courses.CourseById(id.ToString()), UriKind.Relative);
            courseModel = new CoursesModel();
            var response = client.Patch<CoursesModel, CoursesModel>(uri, courseModel, out statusCode);
            Assert.IsTrue(response.IsActive, "Course must be enabled (true)");
            return this;
        }
    }

}

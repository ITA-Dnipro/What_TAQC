using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using What_APIObject.Entities.Accounts;
using What_APIObject.Entities.Courses;
using What_Common.Utils;

namespace What_APIObject.Objects.Courses
{
    public class CourseObject
    {
        private WHATClient client;
        private Uri uri;
        private HttpStatusCode statusCode;
        private AccountUser accountUser;
        private CoursesModel courseModel;
        private CoursesPostModel coursePostModel;
        private CoursesGetModel courseGetModel;

        public CourseObject(User user)
        {
            client = new WHATClient(user);
        }

        /// <summary>
        /// Send GET Request and get all courses 
        /// </summary>
        /// <returns>CourseObject</returns>
        public CourseObject GetAllCourses()
        {
            uri = new Uri($"/api/v2/courses", UriKind.Relative);
            var response = client.Get(uri, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        /// <summary>
        /// Send GET Request and get all active courses
        /// </summary>
        /// <param name="isActive">Boolean parametr that check is unactive course</param>
        /// <returns>CourseObject</returns>
        public CourseObject GetOnlyActiveCourses(bool? isActive)
        {
            uri = new Uri($"/api/v2/courses", UriKind.Relative);
            courseGetModel = new CoursesGetModel();
            courseGetModel.IsActive = true;
            var response = client.Get(uri, courseGetModel, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        /// <summary>
        /// Send GET Request and get all unactive courses 
        /// </summary>
        /// <param name="isActive">Boolean parametr that check is active course</param>
        /// <returns></returns>
        public CourseObject GetOnlyUnactiveCourses(bool? isActive)
        {
            uri = new Uri($"/api/v2/courses", UriKind.Relative);
            courseGetModel = new CoursesGetModel();
            courseGetModel.IsActive = false;
            var response = client.Get(uri, courseGetModel, out statusCode);
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        /// <summary>
        /// Send POST request and create new Course
        /// </summary>
        /// <param name="courseName">Name of course</param>
        /// <returns>CourseObject</returns>
        public CourseObject CreateNewCourse(string courseName)
        {
            uri = new Uri($"/api/v2/courses", UriKind.Relative);
            coursePostModel = new CoursesPostModel();
            coursePostModel.Name = courseName;
            var response = client.Post<CoursesPostModel, CoursesModel>(uri, coursePostModel, out statusCode);
            this.courseModel = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        //Temp methods
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
            uri = new Uri($"/api/v2/courses/{courseModel.Id}", UriKind.Relative);
            var response = client.Delete(uri, out statusCode);
            Assert.IsTrue(response.Contains("false"), "Course is disabled");
            return this;
        }
    }

}

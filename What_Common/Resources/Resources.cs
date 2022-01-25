using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_Common.Resources
{
    public class Resources
    {
        public const string url = "http://localhost:8080/auth";
        public const string empty = "";
        public const string ErrorFieldName = "This field is required";
        public const string firstName = "Qwerty";
        public const string lastName = "Qwerty";
        public const string Email = "Qwe4r29@gma.com";
        public const string Password = "Sergey1900+"; 
        public const string UserNotFound = "User not found in table"; 
        public const string WhatUrl = "http://localhost:8080/";
	    public const string WhatResetPasswordUrl = @"http://localhost:8080/reset-password";
        public const string WhatStudentsUrl = @"http://localhost:8080/students";
        public const string WhatSecretariesUrl = @"http://localhost:8080/secretaries";
        public const string WhatCoursesUrl = @"http://localhost:8080/courses";
        public const string WhatCoursesDetailsUrl = @"http://localhost:8080/courses/1";
        public const string WhatAddNewCourseUrl = @"http://localhost:8080/courses/add";
        public const string WhatMyProfileUrl = @"http://localhost:8080/my-profile";
        public static class ForgotPassword
        {
            public const string modalWindowText = "Please check your email and follow the link to reset your password.";
            public const string invalidEmailError = "Invalid email address";
            public const string emptyEmailError = "This field is required";
            public const string invalidEmail = "com@com";
            public const string doesntExistEmail = "lastname@gmail.com";

            public static string DoesntExistEmailError(string email)
            {
                return $"Account with email {email} does not exist!";
            }
        }
        public static class ChangePassword
        {
            public const string passwordOld = "765Rt##asd4";
            public const string passwordNew = "765Rt##asd";
            public const string secretarEmail = "Adrian@secretar.com";
            public const string password = "765Rt##asd";
            public const string secretaryEmail = "Bernard@secretar.com";
            public const string secretaryPassword = "765Rt##asd";

        }
            #region SignIn_Students
            public static readonly string AuthPageUrl = "http://localhost:8080/auth";
        public static readonly string StudentsPageUrl = "http://localhost:8080/students";
        public static readonly string MentorsPageUrl = "http://localhost:8080/mentors";
        public static readonly string LessonsPageUrl = "http://localhost:8080/lessons";
        public static readonly string CoursesPageUrl = "http://localhost:8080/courses";
        public static readonly string UnassignedUsersUrl = "http://localhost:8080/unassigned";
        public static readonly string RegistrationUrl = "http://localhost:8080/registration";
        public static readonly string ForgotPasswordUrl = "http://localhost:8080/forgot-password";
        #endregion

    }
}

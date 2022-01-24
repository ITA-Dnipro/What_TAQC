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
        public const string Email = "Qwe4r7279@gma.com";
        public const string Password = "Sergey1900+";
        public const string WhatUrl = "http://localhost:8080/";
	    public const string WhatResetPasswordUrl = @"http://localhost:8080/reset-password";
        public const string WhatStudentsUrl = @"http://localhost:8080/students";
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
    }
}

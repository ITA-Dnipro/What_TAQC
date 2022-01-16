using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_Common.Resources
{
    public class Resources
    {
        public const string WhatUrl = "http://localhost:8080/";
      
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

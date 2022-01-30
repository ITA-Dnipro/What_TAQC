using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_APITest.Entities.Accounts;

namespace What_APITest.API_Tests
{
    public class RegistrationTest
    {
        RegistrationPage registration;
        RegistrationNewUser registrationNewUser;    
        [SetUp]
        public void Setup()
        {
            registration = new RegistrationPage();
            registrationNewUser = new RegistrationNewUser()
            {
                FirstName = "st8rin",
                LastName = "st8ring",
                Email = "use8r@example.com",
                Password = "Qtringst1!",               
                ConfirmPassword = "Qtringst1!",
            };    

        }
        [Test]
        public void Test1()
        {
            registration
                .AddNewUser(registrationNewUser)   
                .VerifyRegistration();
        }
    }
}

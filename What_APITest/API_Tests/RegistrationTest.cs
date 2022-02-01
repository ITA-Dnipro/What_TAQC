using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_APIObject.Entities.Accounts;
using What_Common.DataProvider;

namespace What_APITest.API_Tests
{
    public class RegistrationTest
    {
        LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
        RegistrationObject registrationObject;
           
        [SetUp]
        public void Setup()
        {
            registrationObject = new RegistrationObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            
        }
        [Test]
        public void Test1()
        {
            registrationObject
                .AddNewUser()   
                .VerifyRegistration();
        }
        //[TearDown]

    }
}

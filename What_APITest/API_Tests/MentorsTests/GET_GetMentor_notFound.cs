using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_APIObject.Entities.Accounts;
using What_APIObject.Objects.Mentors;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.MentorsTests
{
    public class GET_GetMentor_notFound
    {
        LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
        MentorObject mentorObject;

        [SetUp]
        public void Setup()
        {
            mentorObject = new MentorObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            mentorObject.RegistrationNewUser();                
        }
        [Test]
        public void Test1()
        {
            mentorObject.GetMentor()
                .VerifyGetMentorNotFound();
        }
    }
}

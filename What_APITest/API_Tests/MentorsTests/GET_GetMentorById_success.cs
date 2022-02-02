using NUnit.Framework;
using What_APIObject.Entities.Accounts;
using What_APIObject.Objects.Mentors;
using What_Common.DataProvider;

namespace What_APITest.API_Tests
{
    public class GET_GetMentorById_success
    {
        LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
        MentorObject mentorObject;


        [SetUp]
        public void Setup()
        {
            mentorObject = new MentorObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
            mentorObject.RegistrationNewUser()
                .CreateNewMentor(); 
            
        }

        [Test]
        public void VerifyGetMentorById_Success()
        {
             mentorObject.VerifyGetMentorById();
            
        }
    }
}

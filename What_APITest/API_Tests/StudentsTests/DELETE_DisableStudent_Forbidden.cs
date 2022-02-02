//using NUnit.Framework;
//using What_Common.DataProvider;
//using What_APIObject.Entities.Accounts;
//using NUnit.Allure.Attributes;
//using System.Net;
//using What_APIObject.Objects.Students;

//namespace What_APITest.API_Tests.StudentsTests
//{
//    public class DELETE_DisableStudent_Forbidden : BaseTest
//    {
//        StudentsObject studentsObject;

//        [SetUp]
//        public void Before()
//        {
//            LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
//            studentsObject = new StudentsObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });
//            studentsObject.RegisterNewUser();
//            studentsObject.CreateNewStudent();
//        }

//        [Test(Description = "StudentsTests")]
//        [AllureTag("APITests")]
//        [AllureSuite("Students")]
//        [AllureSubSuite("DELETE")]
//        public void VerifyDisableStudent_Forbidden()
//        {
//            LoginDetails student = Controller.GetUser(Controller.UserRole.Student);
//            StudentsObject studentsObjectAsStudent = new StudentsObject(new User { Email = student.Email, Password = student.Password, Role = Controller.UserRole.Student.ToString().ToLower() });
//            studentsObjectAsStudent.VerifyDisableStudent(HttpStatusCode.Forbidden);
//        }

//        [TearDown]
//        public void After()
//        {
//            studentsObject.DisableStudent();
//        }
//    }
//}

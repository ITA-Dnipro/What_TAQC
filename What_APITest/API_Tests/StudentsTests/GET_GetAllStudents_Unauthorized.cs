//using NUnit.Framework;
//using System;
//using What_Common.DataProvider;
//using What_APIObject;
//using What_APIObject.Objects.Students;
//using What_APIObject.Entities.Accounts;
//using What_Common.Utils;
//using NUnit.Allure.Core;
//using NUnit.Allure.Attributes;
//using Allure.Commons;
//using What_Common.Resources;
//using System.Net;

//namespace What_APITest.API_Tests.StudentsTests
//{
//    [AllureNUnit]
//    [TestFixture]
//    public class GET_GetAllStudents_Unauthorized : BaseTest
//    {
//        StudentsObject studentsObject;

//        [Test(Description = "StudentsTests")]
//        [AllureTag("APITests")]
//        [AllureSuite("Students")]
//        [AllureSubSuite("GET")]
//        public void VerifyGetAllStudents_Unauthorized()
//        {
//            //studentsObject.VerifyGetAllStudents(HttpStatusCode.Unauthorized);
//        }

//        [TearDown]
//        public void After()
//        {
//            studentsObject.DisableStudent();
//        }
//    }
//}

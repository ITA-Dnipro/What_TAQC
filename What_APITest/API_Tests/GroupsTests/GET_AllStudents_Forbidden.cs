using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_APIObject.Entities.Accounts;
using What_APITest.API_Object;
using What_APITest.Entities.Groups;
using What_Common.DataProvider;
using What_Common.Utils;

namespace What_APITest.API_Tests.GroupsAPI_Tests
{

    [TestFixture(Author = "Ivan", Description = "Examples")]
    [AllureNUnit]
    internal class GET_AllStudents_Forbidden
    {
        LoginDetails user = Controller.GetUser(Controller.UserRole.Student);
        GroupsAPI_Object students;
        DateModel datemodel;

        PostStudentsGroups postStudentsGroups;
        PostStudentsGroups putStudentsGroups;
        int id;


        [SetUp]
        public void Setup()
        {

            students = new GroupsAPI_Object(new User { Email = user.Email, Password = user.Password, Role = Controller.UserRole.Student.ToString().ToLower() });
            datemodel = new DateModel { StartDate = DateTime.Now.AddYears(-3), FinishDate = DateTime.Now };
            postStudentsGroups = new PostStudentsGroups
            {
                Name = StringGenerator.GenerateString(10),
                CourseId = 1,
                StartDate = DateTime.Now.AddYears(-1),
                FinishDate = DateTime.Now,
                StudentIds = new List<int>() { 13 },
                MentorIds = new List<int>() { 15 }



            };

            putStudentsGroups = new PostStudentsGroups
            {
                Name = StringGenerator.GenerateString(10),
                CourseId = 1,
                StartDate = DateTime.Now.AddYears(-1),
                FinishDate = DateTime.Now,
                StudentIds = new List<int>() { 13 },
                MentorIds = new List<int>() { 15 }


            };
        }

        [Test]

        public void VerifyGroups() //TODO naminggg!!!
        {
            students.VerifyGetAllStudentsGroupsForbidden(datemodel);



        }
    }
}

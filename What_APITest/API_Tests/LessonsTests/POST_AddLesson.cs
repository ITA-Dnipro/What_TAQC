using API;
using API.Models;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Collections.Generic;
using What_APIObject.Entities.Accounts;
using What_APIObject.Objects.Lessons;
using What_Common.DataProvider;
using What_Common.Utils;

namespace What_APITest.API_Tests.LessonsTests
{
    [TestFixture]
    [AllureNUnit]
    public class POST_AddLesson
    {

        AddLessonTestSteps systemUnderTest;

        PreconditionGenerator generator;

        UserInSystem studentOne;
        UserInSystem studentTwo;
        UserInSystem mentor;

        CourseInSystem course;

        GroupInSystem group;

        Lesson lesson;

        [SetUp]
        public void Setup()
        {

            generator = new PreconditionGenerator();

            studentOne = generator.AssignNewUserToRole<UserInSystem>(generator.RegisterNewUser().Id, UserRole.Student);
            studentTwo = generator.AssignNewUserToRole<UserInSystem>(generator.RegisterNewUser().Id, UserRole.Student);
            mentor = generator.AssignNewUserToRole<UserInSystem>(generator.RegisterNewUser().Id, UserRole.Mentor);

            course = generator.CreateNewCourse();

            group = generator.CreateNewGroup(mentor, new List<UserInSystem> { studentOne, studentTwo }, course);

            lesson =
                new LessonBuilder()
                .SetMentorById(mentor.Id)
                .SetStudentsGroupById(group.Id)
                .SetLessonTheme(StringGenerator.GenerateString(10))
                .SetLessonDate(StringGenerator.RandomDay())
                .SetClassBook(LessonBuilder.CreateClassBook(group.StudentIds))
                .Build();
        }
        [TestCaseSource(nameof(GetValidRolesForAddLesson))]
        public void UserWithRightsCanAddLesson(User usr)
        {

            systemUnderTest = new AddLessonTestSteps(usr);

            systemUnderTest
                .VerifyGroupExist(group.Id)
                .VerifyMentorExist(mentor.Id)
                .AddNewLesson(lesson)
                .VerifyNewlyAddedLessonExist(lesson);
        }
        [TestCaseSource(nameof(GetInvalidRolesForAddLesson))]
        public void UserWithoutRightsCantAddLesson(User usr)
        {
            systemUnderTest = new AddLessonTestSteps(usr);

            systemUnderTest
                .TryToAddNewLessonWithoutRight(lesson)
                .VerifyNewlyAddedLessonNotExist();
        }
        [Test]
        public void UnautorizedUserCannotAddLesson()
        {
            systemUnderTest = new AddLessonTestSteps(null);
            systemUnderTest
                .TryToAddNewLessonWithoutRight(lesson)
                .VerifyNewlyAddedLessonNotExistAuth();
        }

        [TearDown]
        public void After()
        {
            generator.DeleteGroup(group.Id);
            generator.DisableCourse(course.Id);
            generator.DisableUser(studentOne.Id, UserRole.Student);
            generator.DisableUser(studentTwo.Id, UserRole.Student);
            generator.DisableUser(mentor.Id, UserRole.Mentor);
        }

        private static IEnumerable<User> GetValidRolesForAddLesson()
        {
            LoginDetails userAdmin = Controller.GetUser(Controller.UserRole.Admin);
            LoginDetails userMentor = Controller.GetUser(Controller.UserRole.Mentor);
            yield return new User { Email = userAdmin.Email, Password = userAdmin.Password, Role = "admin" };
            yield return new User { Email = userMentor.Email, Password = userMentor.Password, Role = "mentor" };
        }
        private static IEnumerable<User> GetInvalidRolesForAddLesson()
        {
            LoginDetails userSecretary = Controller.GetUser(Controller.UserRole.Secretary);
            LoginDetails userStudent = Controller.GetUser(Controller.UserRole.Student);
            yield return new User { Email = userSecretary.Email, Password = userSecretary.Password, Role = "secretary" };
            yield return new User { Email = userStudent.Email, Password = userStudent.Password, Role = "student" };
        }
    }
}
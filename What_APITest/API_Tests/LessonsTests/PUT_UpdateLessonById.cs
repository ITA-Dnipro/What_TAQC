using API;
using API.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using What_APIObject.Entities.Accounts;
using What_APIObject.Objects.Lessons;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.LessonsTests
{
    [TestFixture]
    public class PUT_UpdateLessonById
    {

        AddLessonTestSteps systemUnderTest;

        PreconditionGenerator generator;

        UserInSystem studentOne;
        UserInSystem studentTwo;
        UserInSystem mentor;

        CourseInSystem course;

        GroupInSystem group;

        Lesson lesson;
        Lesson updatedLesson;
        DateTime updatedLessonDate;
        [SetUp]
        public void Setup()
        {

            generator = new PreconditionGenerator();

            studentOne = generator.AssignNewUserToRole<UserInSystem>(generator.RegisterNewUser().Id, UserRole.Student);
            studentTwo = generator.AssignNewUserToRole<UserInSystem>(generator.RegisterNewUser().Id, UserRole.Student);

            mentor = generator.AssignNewUserToRole<UserInSystem>(generator.RegisterNewUser().Id, UserRole.Mentor);

            course = generator.CreateNewCourse();

            group = generator.CreateNewGroup(mentor, new List<UserInSystem> { studentOne, studentTwo }, course);

            lesson = generator.CreateNewLesson(mentor, group);

            updatedLessonDate = lesson.LessonDate.AddHours(-1);

            updatedLesson =
                new LessonBuilder()
                .SetMentorById(lesson.MentorId)
                .SetStudentsGroupById(lesson.StudentGroupId)
                .SetLessonTheme(lesson.ThemeName + "(edited)")
                .SetLessonDate(updatedLessonDate)
                .SetClassBook(lesson.ClassJournal)
                .Build();

        }

        [TestCaseSource(nameof(GetValidRolesForAddLesson))]
        public void UpdateLesson(User user)
        {
            new AddLessonTestSteps(user)
                .UpdateLesson(lesson.Id, updatedLesson)
                .VerifyUpdatedLessonExist(updatedLesson);

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
    }
}

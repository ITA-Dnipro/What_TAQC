using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;

namespace What_UITest.CourseTest
{
    public class DisplayTablesAsStudentTest : BaseTest
    {
        SignInPage signInPage;

        CoursesPage coursesPage;

        [SetUp]
        public void Setup()
        {
            LoginDetails student = Controller.GetUser(Controller.UserRole.Student);
            signInPage = new SignInPage();
            signInPage.LogIn(student.Email, student.Password);
            coursesPage = new CoursesPage();

        }

        [Test]
        [TestCase("Soft Skills for Lecturers")]
        public void IsDisplayingCoursePage(string expectedResult)
        {
            coursesPage.
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow).
                VerifyThatCoursePageDisplayed(expectedResult, 1);

        }

    }
}

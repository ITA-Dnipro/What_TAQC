using NUnit.Framework;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_Common.DataProvider;
using What_PageObject;
using What_Common.DriverManager;
using What_PageObject.MyProfile;

namespace What_UITest.MyProfileTests
{
    public class MyProfileChangePasswordButtonWorkedTestAsStudent : BaseTest
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
        public void VerifyThatChangePasswordButtonWorked()
        {
            coursesPage.
                ClickMyProfileIcon().
                WaitUntilElementLoads<MyProfilePage>(Locators.MyProfilePage.ChangePasswordButton).
                VerifyThatChangePasswordWorked();
        }



        [TearDown]
        public void TearDown()
        {
            Driver.Current.Quit();
        }
    }
}

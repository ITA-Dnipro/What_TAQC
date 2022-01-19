using What_Common.Resources;
using What_Common.DriverManager;
using NUnit.Framework;
using OpenQA.Selenium;

namespace What_PageObject.SignInPage
{
    public class SignInPage : BasePage
    {
        private const int forceSleepTime = 500;

        public void IsAtPage()
        {
            Assert.AreEqual(Driver.Current.Url, Resources.AuthPageUrl);
        }

        public bool IfElementExists(By element)
        {
            return Driver.Current.FindElements(element).Count() > 0;
        }

        #region LogIn
        public SignInPage EnterEmail(string email)
        {
            FillField(Locators.SignIn.EmailField, email);
            return this;
        }

        public SignInPage EnterPassword(string password)
        {
            FillField(Locators.SignIn.PasswordField, password);
            return this;
        }

        public SignInPage ClickSignInButton()
        {
            ClickElement(Locators.SignIn.SignInButton);
            return this;
        }

        public SignInPage LogIn(string email, string password)
        {
            EnterEmail(email);
            EnterPassword(password);
            return ClickSignInButton();
        }
        #endregion

        #region LogInVerify
        public SignInPage VerifyLogInAsAdmin()
        {
            WaitUntilElementLoads<StudentsPage.StudentsPage>(Locators.Students.ListTable);
            string expectedURL = Resources.StudentsPageUrl;
            string actualURL = Driver.Current.Url;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedURL, actualURL);
                Assert.IsTrue(IfElementExists(Locators.Students.AddStudentButton));
            });
            return this;
        }

        public SignInPage VerifyLogInAsSecretary()
        {
            WaitUntilElementLoads<SignInPage>(Locators.SignIn.MentorsPageAddMentor);
            string expectedURL = Resources.MentorsPageUrl;
            string actualURL = Driver.Current.Url;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedURL, actualURL);
                Assert.IsTrue(IfElementExists(Locators.SignIn.NameElement));
            });
            return this;
        }

        public SignInPage VerifyLogInAsMentor()
        {
            WaitUntilElementLoads<SignInPage>(Locators.SignIn.LessonsPageAddLesson);
            string expectedURL = Resources.LessonsPageUrl;
            string actualURL = Driver.Current.Url;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedURL, actualURL);
                Assert.IsTrue(IfElementExists(Locators.SignIn.LessonsPageLessonDate));
            });
            return this;
        }

        public SignInPage VerifyLogInAsStudent()
        {
            WaitUntilElementLoads<SignInPage>(Locators.SignIn.CoursesPageDisabledCourses);
            string expectedURL = Resources.CoursesPageUrl;
            string actualURL = Driver.Current.Url;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedURL, actualURL);
                Assert.IsTrue(IfElementExists(Locators.SignIn.CoursesPageTitle));
            });
            return this;
        }

        #endregion

        #region Registration
        public SignInPage ClickRegistrationButton()
        {
            ClickElement(Locators.SignIn.RegistrationButton);
            return this;
        }
        public SignInPage VerifyRegistrationButton()
        {
            Thread.Sleep(forceSleepTime);
            WaitUntilElementLoads<SignInPage>(Locators.SignIn.RegistrationPageSignUpElement);
            string expectedURL = Resources.RegistrationUrl;
            string actualURL = Driver.Current.Url;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedURL, actualURL);
                Assert.IsTrue(IfElementExists(Locators.SignIn.RegistrationFirstName));
            });
            return this;
        }
        #endregion

        #region ForgotPassword
        public SignInPage ClickForgotPasswordButton()
        {
            ClickElement(Locators.SignIn.ForgotPasswordButton);
            return this;
        }
        public SignInPage VerifyForgotPasswordButton()
        {
            Thread.Sleep(forceSleepTime);
            WaitUntilElementLoads<SignInPage>(Locators.SignIn.ForgotPasswordPageTitle);
            string expectedURL = Resources.ForgotPasswordUrl;
            string actualURL = Driver.Current.Url;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedURL, actualURL);
                Assert.IsTrue(IfElementExists(Locators.SignIn.ForgotPasswordPageEmailText));
            });
            return this;
        }
        #endregion

    }
}

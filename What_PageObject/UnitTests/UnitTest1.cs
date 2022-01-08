using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace SeleniumTest1
{
    public class Tests
    {
        private IWebDriver driver;
     
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //TODO MAximize driver
            //logInPage = new LogInPage(driver);
        }

        [Test]
        [Category("Sign In")]
        [TestCase("james.smith@example.com", "Nj_PJ7K9")]
        public void LogInTestAsAdmin(string login, string password)
        {
            LogInPage loginPage = new LogInPage(driver);
            loginPage.GoToPage();
            loginPage.SetLogin(login, password);
            loginPage.ClickOnFormLogin();
            Assert.IsTrue(Equals("http://localhost:8080/students", driver.Url));

        }

        [Test]
        [Category("Sign In")]
        [TestCase("john.williams@example.com", "9mw6AJB_")]
        public void LogInTestAsSecretary(string login, string password)
        {
            LogInPage loginPage = new LogInPage(driver);
            loginPage.GoToPage();
            loginPage.SetLogin(login, password);
            loginPage.ClickOnFormLogin();
            Assert.IsTrue(Equals("http://localhost:8080/mentors", driver.Url));

        }

        [Test]
        [Category("Sign In")]
        [TestCase("michael.taylor@example.com", "9td6IO_Z")]
        public void LogInTestAsMentor(string login, string password)
        {
            LogInPage loginPage = new LogInPage(driver);
            loginPage.GoToPage();
            loginPage.SetLogin(login, password);
            loginPage.ClickOnFormLogin();
            Assert.IsTrue(Equals("http://localhost:8080/lessons", driver.Url));

        }

        [Test]
        [Category("Sign In")]
        [TestCase("thomas.roberts@example.com", "T_oYiUX5")]
        public void LogInTestAsStudent(string login, string password)
        {
            LogInPage loginPage = new LogInPage(driver);
            loginPage.GoToPage();
            loginPage.SetLogin(login, password);
            loginPage.ClickOnFormLogin();
            Assert.IsTrue(Equals("http://localhost:8080/courses", driver.Url));

        }

        [Test]
        [Category("My Profile")]
        [TestCase("thomas.roberts@example.com", "T_oYiUX5")]
        public void MyProfileTestAsStudent(string login, string password)
        {
            LogInPage loginPage = new LogInPage(driver);
            CoursePage coursePage = new CoursePage(driver);
            MyProfilePage myProfile = new MyProfilePage(driver);
            loginPage.GoToPage();
            loginPage.SetLogin(login, password);
            loginPage.ClickOnFormLogin();
            coursePage.ClickMyProfileIcon();
            Assert.IsTrue(Equals("http://localhost:8080/my-profile", driver.Url));

        }

        [Test]
        [Category("My Profile")]
        [TestCase("thomas.roberts@example.com", "T_oYiUX5")]
        public void IsChangePasswordBtnEnabledAsStudent(string login, string password)
        {
            LogInPage loginPage = new LogInPage(driver);
            CoursePage coursePage = new CoursePage(driver);
            MyProfilePage myProfile = new MyProfilePage(driver);
            loginPage.GoToPage();
            loginPage.SetLogin(login, password);
            loginPage.ClickOnFormLogin();
            coursePage.ClickMyProfileIcon();
            myProfile.ChangePasswordClick();
            Assert.IsTrue(Equals("http://localhost:8080/change-password", driver.Url));

        }

        [Test]
        [Category("My Profile")]
        [TestCase("james.smith@example.com", "Nj_PJ7K9")]
        public void adminHover(string login, string password)
        {
            LogInPage loginPage = new LogInPage(driver);
            CoursePage coursePage = new CoursePage(driver);
            loginPage.GoToPage();
            loginPage.SetLogin(login, password);
            loginPage.ClickOnFormLogin();
            coursePage.MouseHover();
            coursePage.ClickMentorsMenuItem();
            Assert.IsTrue(Equals("http://localhost:8080/my-profile", driver.Url));

        }

        //public bool IsLoginSuccessful(Roles role)
        //{
        //    bool flag = false;

        //    switch (role)
        //    {
        //        case Roles.Admin:
        //            flag = Equals("http://localhost:8080/students", driver.Url);
        //            break;
        //        case Roles.Secretary:
        //            flag = Equals("http://localhost:8080/mentors", driver.Url);
        //            break;
        //        case Roles.Mentor:
        //            flag = Equals("http://localhost:8080/lessons", driver.Url);
        //            break;
        //        case Roles.Student:
        //            flag = Equals("http://localhost:8080/courses", driver.Url);
        //            break;
        //    }
        //    return flag;
        //}

      
    }
}
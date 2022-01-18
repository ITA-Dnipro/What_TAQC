using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using What_Common.DriverManager;
using What_PageObject.SignInPage;
using What_PageObject.Course;
using What_Common.Resources;
using What_PageObject.StudentsPage;

namespace What_UITest.CourseTest
{
    public class LogInTestValid
    {
        SignInPage signInPage;
        
        CoursesPage coursesPage;

        StudentsPage studentsPage;

        [SetUp]
        public void Setup()
        {
            Driver.MaximizeWindow();
            Driver.GoToUrl();
            signInPage = new SignInPage();
            coursesPage = new CoursesPage(Driver.Current);
            studentsPage = new StudentsPage();

        }

        [Test]
        [TestCase("james.smith@example.com", "Nj_PJ7K9")]
        public void IsDisplayingCoursePage(string login, string password)
        {
            //signInPage.LogIn(login, password).
            //    WaitUntilElementLoads<StudentsPage>(Locators.Students.ListTable).
            //    ClickCoursesPage().
            //    VerifyThatCoursePageDisplayed();
            
        }

    }
}

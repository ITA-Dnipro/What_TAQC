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

namespace What_UITest.SignInTests
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
            signInPage = new SignInPage(Driver.Current);
            coursesPage = new CoursesPage(Driver.Current);
            studentsPage = new StudentsPage();

        }

        [Test]
        [TestCase("james.smith@example.com", "Nj_PJ7K9", "http://localhost:8080/students")]
        public void Test1(string login, string password, string expectedUrl)
        {
            signInPage.LogIn(login, password, expectedUrl).
                WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow)
                .VerifyThatCourseTableAsRowsDisplayed();
            
        }

    }
}

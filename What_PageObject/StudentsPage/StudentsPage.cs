using What_Common.Resources;
using What_Common.DriverManager;
using What_PageObject.Course;
using OpenQA.Selenium;
using NUnit.Framework;
using SeleniumExtras.WaitHelpers;

namespace What_PageObject.StudentsPage
{
    public class StudentsPage : BasePageWithSideBar
    {
        private const int forceSleepTime = 500;

        public bool IfElementExists(By element)
        {
            return Driver.Current.FindElements(element).Count() > 0;
        }

        public StudentsPage ClickStudentsSideBar()
        {
            ClickElement(Locators.SideBar.StudentPageLink);
            return this;
        }

        public StudentsPage ClickAddStudentButton()
        {
            ClickElement(Locators.Students.AddStudentButton);
            return this;
        }

        public StudentsPage VerifyAddStudent()
        {
            Thread.Sleep(forceSleepTime);
            WaitUntilElementLoads<SignInPage.SignInPage>(Locators.Students.UnassignedUsersTitle);
            string expectedURL = Resources.UnassignedUsersUrl;
            string actualURL = Driver.Current.Url;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedURL, actualURL);
                Assert.IsTrue(IfElementExists(Locators.Students.UnassignedUsersName));
            });
            return this;
        }

    }
}

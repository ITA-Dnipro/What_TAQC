using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.MyProfile;

namespace What_PageObject.Course
{
    public class CoursesPage : BasePageWithSideBar
    {
        private Waiter waiter;

        public CoursesPage()
        {
            
            this.waiter = new Waiter(Driver.Current);
        }

        /// <summary>
        /// Goes to my profile page
        /// </summary>
        /// <returns>My Profile Page</returns>
        public MyProfilePage ClickMyProfileIcon()
        {
            ClickElement(Locators.NavBar.IconLink);
            waiter.wait.Until(ExpectedConditions.UrlMatches(Resources.WhatMyProfileUrl));
            return new MyProfilePage(Driver.Current);
        }

        /// <summary>
        /// Show table of courses in row element
        /// </summary>
        /// <returns>CoursePage</returns>
        public CoursesPage ClickRowCourseView()
        {
            ClickElement(Locators.ListOfCoursesPage.ViewRowsButton);
            WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow);
            return this;
        }

        /// <summary>
        /// Show table of courses in card element
        /// </summary>
        /// <returns>CoursePage</returns>
        public CoursesPage ClickCardCourseView()
        {
            ClickElement(Locators.ListOfCoursesPage.ViewCardsButton);
            WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInCards);
            return this;
        }

        /// <summary>
        /// Click on course on sidebar panel
        /// </summary>
        /// <returns>Course Page</returns>
        public CoursesPage ClickCoursesPage()
        {
            SidebarNavigateTo<CoursesPage>();
            return new CoursesPage();
        }

        /// <summary>
        /// Click left arrow on pagination
        /// </summary>
        /// <returns>Previous page with courses table</returns>
        public CoursesPage ClickPreviousPageOnPagination()
        {
            ClickElement(Locators.ListOfCoursesPage.PreviousButtonPage);
            return this;
        }

        /// <summary>
        /// Clcik right arrow on pagination
        /// </summary>
        /// <returns>Next page with courses table</returns>
        public CoursesPage ClickNextPageOnPagination()
        {
            ClickElement(Locators.ListOfCoursesPage.NextButtonPage);
            return this;
        }

        /// <summary>
        /// Inputs text to search field
        /// </summary>
        /// <param name="text">Text to input</param>
        /// <returns>Course Page</returns>
        public CoursesPage SearchByName(string text)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Current, TimeSpan.FromSeconds(10));
            wait.Until(e => e.FindElements(Locators.ListOfCoursesPage.CourseTableInRow));
            FillField(Locators.ListOfCoursesPage.SearchField, text);
            return this;
        }

        /// <summary>
        /// Redirect you to edit Course Page from row view
        /// </summary>
        /// <param name="courseName">Name of course</param>
        /// <returns>Edit Course Page</returns>
        public EditCoursePage ClickEditButtonFromRow(int id)
        {
            string courseName = Driver.Current.FindElement(Locators.ListOfCoursesPage.EditInRowsCourseElement(id)).Text;
            ClickElement(Locators.ListOfCoursesPage.EditInRowsCourseElement(id));
            return new EditCoursePage(Driver.Current, courseName, id);
        }

        /// <summary>
        /// Redirect you to edit Course Page from cards view
        /// </summary>
        /// <param name="courseName">Name of course</param>
        /// <returns>Edit Course Page</returns>
        public EditCoursePage ClickEditButtonFromCards(int id)
        {
            string courseName = Driver.Current.FindElement(Locators.ListOfCoursesPage.EditInRowsCourseElement(id)).Text;
            ClickElement(Locators.ListOfCoursesPage.EditInRowsCourseElement(id));
            return new EditCoursePage(Driver.Current, courseName, id);
        }

        /// <summary>
        /// Redirect you to details Course Page from row view
        /// </summary>
        /// <param name="courseName">Name of course</param>
        /// <returns>Course Details Page</returns>
        public CourseDetailsPage ClickDetailsButtonFromRow(int id)
        {
            string courseName = Driver.Current.FindElement(Locators.ListOfCoursesPage.DetailsInRowsViewButton(id)).Text;
            ClickElement(Locators.ListOfCoursesPage.DetailsInRowsViewButton(id));
            waiter.wait.Until(ExpectedConditions.UrlMatches(Resources.WhatCoursesDetailsUrl));
            return new CourseDetailsPage(Driver.Current, courseName, id);
        }

        /// <summary>
        /// Redirect you to details Course Page from cards view
        /// </summary>
        /// <param name="courseName">Name of course</param>
        /// <returns>Course Details Page</returns>
        public CourseDetailsPage ClickDetailsButtonFromCards(int id)
        {
            string courseName = Driver.Current.FindElement(Locators.ListOfCoursesPage.DetailsInCardViewButton(id)).Text;
            ClickElement(Locators.ListOfCoursesPage.DetailsInCardViewButton(id));
            waiter.wait.Until(ExpectedConditions.UrlMatches(Resources.WhatCoursesDetailsUrl));
            return new CourseDetailsPage(Driver.Current, courseName, id);
        }

        /// <summary>
        /// Redirect you to AddCourse page
        /// </summary>
        /// <returns>Add Course Page</returns>
        public AddCoursePage ClickAddCourseButton()
        {
            ClickElement(Locators.ListOfCoursesPage.AddCourseButton);
            return new AddCoursePage(Driver.Current);
        }


        /// <summary>
        /// Called test that verify is page course displayed correctly 
        /// </summary>
        /// <returns>Course Page</returns>
        public CoursesPage VerifyThatCoursePageDisplayed(string expectedCourseName, int id)
        {
            string actualName = Driver.Current.FindElement(Locators.ListOfCoursesPage.DetailsInRowsViewButton(id)).Text;
            Assert.Multiple(() =>
            {
                Assert.AreEqual(Resources.WhatCoursesUrl, Driver.Current.Url);
                Assert.AreEqual(expectedCourseName, actualName);
                ClickCardCourseView().WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInCards);
                Assert.AreEqual(Resources.WhatCoursesUrl, Driver.Current.Url);
                Assert.AreEqual(expectedCourseName, actualName);
            });
           
            return this;
        }

       



        //public CoursesPage VerifyThatPaginationWork(string expectedCourseName, int id)
        //{
        //    string actualName = Driver.Current.FindElement(Locators.ListOfCoursesPage.DetailsInRowsViewButton(id)).Text;
        //    ClickNextPageOnPagination().
        //      WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow);

        //    //string actualName = Driver.Current.FindElement(Locators.ListOfCoursesPage.DetailsInRowsViewButton(1)).Text;
        //    Assert.Multiple(() =>
        //    {
        //        ClickNextPageOnPagination()
        //            .WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInCards);
        //        Assert.AreNotEqual(expectedCourseName, actualName);
        //        ClickPreviousPageOnPagination().WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow)
        //        //ClickCardCourseView().WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInCards);

        //    });

        //    return this;
        //}
    }
}
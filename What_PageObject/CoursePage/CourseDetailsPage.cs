//using OpenQA.Selenium;
//using What_Common.Resources;

//namespace What_PageObject.Course
//{
//    public class CourseDetailsPage : BasePage
//    {
//        private IWebDriver driver;

//        private Waiter waiter;

//        private string courseName;

//        public CourseDetailsPage(IWebDriver driver, string courseName)
//        {
//            this.driver = driver;
//            this.waiter = new Waiter(driver);
//            this.courseName = courseName;
//        }

//        public EditCoursePage ClickEditCourseTab()
//        {
//            ClickElement(Locators.CourseDetails.EditCourseDetailsTab);
//            //waiter.wait.Until(ExpectedConditions.UrlMatches("http://localhost:8080/my-profile"));
//            return new EditCoursePage(driver, courseName);
//        }

//        //public CourseDetails ClickCourseDetailsTab()
//        //{
//        //    ClickElement(Locators.CourseDetails.CourseDetailsTab);
//        //    return this;
//        //}

//        public CoursesPage ArrowClick()
//        {
//            ClickElement(Locators.CourseDetails.ArrowBackLink);
//            return new CoursesPage(driver);
//        }

//        public bool IsCourseIdCorrect()
//        {
//            return Equals(driver.FindElement(Locators.CourseDetails.CourseName).Text, courseName);
//        }
//    }
//}
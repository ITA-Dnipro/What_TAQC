using OpenQA.Selenium;
using What_Common.Resources;

namespace What_PageObject.Course
{
    public class EditCoursePage : BasePage
    {
        private IWebDriver driver;

        private Waiter waiter;

        private string courseName;

        private int courseId;

        public EditCoursePage(IWebDriver driver, string courseName, int courseId)
        {
            this.driver = driver;
            this.waiter = new Waiter(driver);
            this.courseName = courseName;
            this.courseId = courseId;
        }

        public EditCoursePage FillTextBox(string text)
        {
            if (text != "" || text != null || text.Length < 50)
            {
                courseName = text;
                FillField(Locators.EditCourseDetails.CourseNameField, courseName);
            }
            return new EditCoursePage(driver, courseName, courseId);
        }

        public EditCoursePage SaveButtonClick()
        {

            return this;
        }

        public EditCoursePage ResetButtonClick()
        {

            return this;
        }

        public EditCoursePage DisableButtonClick()
        {

            return this;
        }

        public CourseDetailsPage ClickCourseDetailsTab()
        {
            ClickElement(Locators.EditCourseDetails.CourseDetailsTab);
            return new CourseDetailsPage(driver, courseName, courseId);
        }

        public CoursesPage ArrowClick()
        {
            ClickElement(Locators.EditCourseDetails.ArrowBackLink);
            return new CoursesPage();
        }

        
    }
}
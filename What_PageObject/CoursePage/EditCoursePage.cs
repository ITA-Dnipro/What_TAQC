using OpenQA.Selenium;
using What_Common.Resources;

namespace What_PageObject.Course
{
    public class EditCoursePage : BasePage
    {
        private IWebDriver driver;

        private Waiter waiter;

        private string courseName;

        public EditCoursePage(IWebDriver driver, string courseName)
        {
            this.driver = driver;
            this.waiter = new Waiter(driver);
            this.courseName = courseName;
        }

        public EditCoursePage FillTextBox(string text)
        {
            if (text != "" || text != null || text.Length < 50)
            {
                courseName = text;
                FillField(Locators.EditCourseDetails.CourseNameField, courseName);
            }
            return new EditCoursePage(driver, courseName);
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
            return new CourseDetailsPage(driver, courseName);
        }

        public CoursesPage ArrowClick()
        {
            ClickElement(Locators.EditCourseDetails.ArrowBackLink);
            return new CoursesPage();
        }

        
    }
}
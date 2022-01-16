using OpenQA.Selenium;

namespace What_PageObject.Course
{
    public class CourseDetails
    {
        private IWebDriver driver;

        public CourseDetails(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
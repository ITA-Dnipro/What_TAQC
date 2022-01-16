using OpenQA.Selenium;

namespace What_PageObject.Course
{
    public class EditCourse
    {
        private IWebDriver driver;

        public EditCourse(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
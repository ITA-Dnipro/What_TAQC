using OpenQA.Selenium;

namespace What_PageObject.Course
{
    public class AddCourse
    {
        private IWebDriver driver;

        public AddCourse(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
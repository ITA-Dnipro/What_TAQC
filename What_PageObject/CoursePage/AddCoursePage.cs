using OpenQA.Selenium;

namespace What_PageObject.Course
{
    public class AddCoursePage
    {
        private IWebDriver driver;

        public AddCoursePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
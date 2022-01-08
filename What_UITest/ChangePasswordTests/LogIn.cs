
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace What_UITest.ChangePasswordTests
{
    public class Login
    {
        protected IWebDriver driver;
        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By emailNameBy = By.XPath("//*[@id=\"email\"]");
        private By passwordNameBy = By.XPath("//*[@id=\"password\"]");
        private By loginButtonBy = By.XPath("//*[@class=\"btn button__default___3hOmG button__button___24ZfP auth__form-button___3KEpa\"]");
        private By adminMessageBy = By.XPath("//*[@class=\"col-6\"][text()=\"Students\"]");
        private By secretaryMessageBy = By.XPath("//*[@class=\"col-6\"][text()=\"Mentors\"]");
        private By mentorMessageBy = By.XPath("//*[@class=\"col-6\"][text()=\"Lessons\"]");
        private By studentMessageBy = By.XPath("//*[@class=\"col-6\"][text()=\"Courses\"]");

        
        public Login FillEmail(string email)
        {
            driver.FindElement(emailNameBy).SendKeys(email);

            return this;
        }

        public Login FillPassword(string password)
        {
            driver.FindElement(passwordNameBy).SendKeys(password);

            return this;
        }

        public Login ClickLoginButton()
        {
            driver.FindElement(loginButtonBy).Click();

            return this;
        }

        public string GetAdminEqualMessageText()
        {
            return driver.FindElement(adminMessageBy).Text;
        }

        public string GetSecretaryEqualMessageText()
        {
            return driver.FindElement(secretaryMessageBy).Text;
        }

        public string GetMentorEqualMessageText()
        {
            return driver.FindElement(mentorMessageBy).Text;
        }

        public string GetStudentEqualMessageText()
        {
            return driver.FindElement(studentMessageBy).Text;
        }
    }
}
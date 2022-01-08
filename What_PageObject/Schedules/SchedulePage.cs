using OpenQA.Selenium;
using What_PageObject.BasePage;
using WHAT_PageObject.Constants;

namespace WHAT_PageObject.Schedules
{
    public class SchedulePage : BasePage
    {
        IWebDriver driver;

        private By topDropdownMenu = By.XPath(LocatorsPath.topDropdownMenuXpath);
        private By logoutButton = By.XPath(LocatorsPath.logoutButtonXpath);
        private By calendarMenuButton = By.XPath(LocatorsPath.calendarMenuXpath);
        private By todayButton = By.XPath(LocatorsPath.todayButtonXpath);
        private By leftArrowShedulesButton = By.XPath(LocatorsPath.leftArrowShedulesXpath);
        private By rightArrowShedulesButton = By.XPath(LocatorsPath.rightArrowShedulesXpath);
        private By clickToNavbarMenuSheduleButton = By.XPath(LocatorsPath.clickToNavbarMenuSheduleXpath);

        public SchedulePage(IWebDriver driver) : base(driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public SchedulePage Logout()
        {
            driver.FindElement(topDropdownMenu).Click();
            driver.FindElement(logoutButton).Click();

            return this;
        }

        public SchedulePage NextDate()
        {
            ClickElement(rightArrowShedulesButton);

            return this;
        }

        public SchedulePage PrevDate()
        {
            ClickElement(leftArrowShedulesButton);

            return this;
        }
    }
}

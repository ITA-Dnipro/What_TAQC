using OpenQA.Selenium;
using What_PageObject.BasePage;
using WHAT_PageObject.Constants;

namespace WHAT_PageObject.UnassignedUsers
{
    public class UnassignedUserPage : BasePage
    {
        IWebDriver driver;

        private By topDropdownMenu = By.XPath(LocatorsPath.topDropdownMenuXpath);
        private By logoutButton = By.XPath(LocatorsPath.logoutButtonXpath);
        private By topLeftArrowButton = By.XPath(LocatorsPath.topLeftArrowListOfAssignmentsXpath);
        private By topRightArrowButton = By.XPath(LocatorsPath.topRightArrowListOfAssignmentsXpath);
        private By bottomLeftArrowShedulesButton = By.XPath(LocatorsPath.bottomLeftArrowListOfAssignmentsXpath);
        private By bottomRightArrowButton = By.XPath(LocatorsPath.bottomRightArrowListOfAssignmentsXpath);
        private By searchInputField = By.XPath(LocatorsPath.searchInputXpath);
        private By dropDownButton = By.XPath(LocatorsPath.dropDownButtonXpath);
        private By clickToNavbarMenuSheduleButton = By.XPath(LocatorsPath.clickToNavbarMenuListOfUnassignedXpath);

        public UnassignedUserPage(IWebDriver driver) : base(driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public UnassignedUserPage Logout()
        {
            driver.FindElement(topDropdownMenu).Click();
            driver.FindElement(logoutButton).Click();

            return this;
        }
    }
}

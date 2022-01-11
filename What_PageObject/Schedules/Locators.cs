using OpenQA.Selenium;
using WHAT_PageObject.Schedules;

namespace What_PageObject.Schedules
{
    public static class Locators
    {
        public static By TopDropdownMenuButton = By.XPath(LocatorsPath.topDropdownMenuXpath);
        public static By LogoutButton = By.XPath(LocatorsPath.logoutButtonXpath);
        public static By CalendarMenu = By.XPath(LocatorsPath.calendarMenuXpath);
        public static By TodayButton = By.XPath(LocatorsPath.todayButtonXpath);
        public static By LeftArrowShedulesButton = By.XPath(LocatorsPath.leftArrowShedulesXpath);
        public static By RightArrowShedulesButton = By.XPath(LocatorsPath.rightArrowShedulesXpath);
        public static By ClickToNavbarMenuSheduleButton = By.XPath(LocatorsPath.clickToNavbarMenuSheduleXpath);
        public static By InputDateField = By.XPath(LocatorsPath.inputDateXpath);
        public static By DateText = By.XPath(LocatorsPath.dateXpath);
        public static By StartTableDateCsspath = By.CssSelector(LocatorsPath.StartTableDateCsspath);
        public static By EndTableDateCsspath = By.CssSelector(LocatorsPath.EndTableDateCsspath);
    }
}

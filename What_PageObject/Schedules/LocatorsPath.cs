namespace WHAT_PageObject.Schedules
{
    public static class LocatorsPath
    {
        #region GeneralLocators

        public const string adminExpectedXpath = "//*[@class='col-6'][text()='Students']";
        public const string secretaryExpectedXpath = "//*[@class='col-6'][text()='Mentors']";
        public const string mentorExpectedXpath = "//*[@class='col-6'][text()='Lessons']";
        public const string studentExpectedXpath = "//*[@class='col-6'][text()='Courses']";

        #endregion

        #region LoginPageLocators

        public const string emailXpath = "//*[@id='email']";
        public const string passwordXpath = "//*[@id='password']";
        public const string loginButtonXpath = "//button[@type='submit']";

        #endregion

        #region LogoutLocators

        public const string topDropdownMenuXpath = "//*[@class='header__header__dropdown-icon___1CTJ8']";
        public const string logoutButtonXpath = "//*[@class='header__header__dropdown-list-show___2kO4i']//*[text()='Log Out']";

        #endregion

        #region ShedulesLocators

        public const string calendarMenuXpath = "//*[@class='schedule__date-input___2glbe']";
        public const string todayButtonXpath = "//button[contains(.,'Today')]";
        public const string leftArrowShedulesXpath = "//*[@class='schedule__arrow___1kCJf schedule__arrow-left___1WRTh']";
        public const string rightArrowShedulesXpath = "//*[@class='schedule__arrow___1kCJf']";
        public const string clickToNavbarMenuSheduleXpath = "//a[contains(.,'Schedule')]";
        public const string inputDateXpath = "//*[@id='root']//*[@class='schedule__date-input___2glbe']";
        public const string dateXpath = "//*[@class = 'mb-0']";
        public const string StartTableDateCsspath = ".col:nth-child(1) .text-center:nth-child(2)";
        public const string EndTableDateCsspath = ".col:nth-child(7) .text-center:nth-child(2)";

        #endregion

        #region ListOfUnassignedLocators

        public const string topLeftArrowListOfAssignmentsXpath = "//*[@class='row justify-content-between align-items-center mb-3']//*[text()='<']";
        public const string topRightArrowListOfAssignmentsXpath = "//*[@class='row justify-content-between align-items-center mb-3']//*[text()='>']";
        public const string bottomLeftArrowListOfAssignmentsXpath = "//*[@class='row justify-content-between align-items-center mb-3 unassigned-list__paginate___2mqJX']//*[text()='<']";
        public const string bottomRightArrowListOfAssignmentsXpath = "//*[@class='row justify-content-between align-items-center mb-3 unassigned-list__paginate___2mqJX']//*[text()='>']";
        public const string searchInputXpath = "//input[@type='text']";
        public const string dropDownButtonXpath = "//select[@id='change-visible-people']";
        public const string clickToNavbarMenuListOfUnassignedXpath = "//span[contains(.,'Assignment')]";
        public const string firstPageXpath = "//ul[2]/li";
        public const string lastPageXpath = "//ul[2]/li[last()]";
        public const string sortedByName = "//th[1]/span";
        public const string sortedBySurname = "//th[2]/span";
        public const string sortedByEmail = "//th[3]/span";
        public const string tableData = "//tbody/tr";

        public const string unassignedUserLastName = "//tbody/tr[{row}]/td[2]";
        public const string unassignedUserEmail = "//tbody/tr[{row}]/td[3]";

        #endregion
    }
}
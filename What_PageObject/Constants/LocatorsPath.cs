namespace WHAT_PageObject.Constants
{
    public static class LocatorsPath
    {
        #region GeneralLocators

        public const string adminExpectedXpath = "//*[@class=\"col-6\"][text()=\"Students\"]";
        public const string secretaryExpectedXpath = "//*[@class=\"col-6\"][text()=\"Mentors\"]";
        public const string mentorExpectedXpath = "//*[@class=\"col-6\"][text()=\"Lessons\"]";
        public const string studentExpectedXpath = "//*[@class=\"col-6\"][text()=\"Courses\"]";

        public const string topDropdownMenuXpath = "//*[@class=\"header__header__dropdown-icon___1CTJ8\"]";
        public const string logoutButtonXpath = "//*[@class=\"header__header__dropdown-list-show___2kO4i\"]//*[text()=\"Log Out\"]";

        #endregion

        #region LoginPageLocators

        public const string emailXpath = "//*[@id=\"email\"]";
        public const string passwordXpath = "//*[@id=\"password\"]";
        public const string loginButtonXpath = "//*[@class=\"btn button__default___3hOmG button__button___24ZfP auth__form-button___3KEpa\"]";

        #endregion

        #region ShedulesLocators

        public const string calendarMenuXpath = "//*[@class=\"schedule__date-input___2glbe\"]";
        public const string todayButtonXpath = "//*[@class=\"btn btn-info button__button___24ZfP ml-2\"]";
        public const string leftArrowShedulesXpath = "//*[@class=\"schedule__arrow___1kCJf schedule__arrow-left___1WRTh\"]";
        public const string rightArrowShedulesXpath = "//*[@class=\"schedule__arrow___1kCJf\"]";
        public const string clickToNavbarMenuSheduleXpath = "//*[@class=\"sidebar__sidebar__links___GkXK-\"]//span[text()=\"Schedule\"]";

        #endregion

        #region ListOfAssignmentsLocators

        public const string topLeftArrowListOfAssignmentsXpath = "//*[@class=\"row justify-content-between align-items-center mb-3\"]//*[text()=\"<\"]";
        public const string topRightArrowListOfAssignmentsXpath = "//*[@class=\"row justify-content-between align-items-center mb-3\"]//*[text()=\">\"]";
        public const string bottomLeftArrowListOfAssignmentsXpath = "//*[@class=\"row justify-content-between align-items-center mb-3 unassigned-list__paginate___2mqJX\"]//*[text()=\"<\"]";
        public const string bottomRightArrowListOfAssignmentsXpath = "//*[@class=\"row justify-content-between align-items-center mb-3 unassigned-list__paginate___2mqJX\"]//*[text()=\">\"]";
        public const string searchInputXpath = "//*[@class=\"search__searchInput___34nMl\"]";
        public const string dropDownButtonXpath = "//*[@id=\"change-visible-people\"]";
        public const string clickToNavbarMenuListOfUnassignedXpath = "//*[@class=\"sidebar__sidebar__links___GkXK-\"]//span[text()=\"Assignment\"]";

        #endregion
    }
}
using OpenQA.Selenium;
using WHAT_PageObject.UnassignedUsers;

namespace What_PageObject.UnassignedUsers
{
    public static class Locators
    {
        public static By TopDropdownMenuButton = By.XPath(LocatorsPath.topDropdownMenuXpath);
        public static By TopDropdownLogoutButton = By.XPath(LocatorsPath.logoutButtonXpath);
        public static By TopLeftArrowButton = By.XPath(LocatorsPath.topLeftArrowListOfAssignmentsXpath);
        public static By TopRightArrowButton = By.XPath(LocatorsPath.topRightArrowListOfAssignmentsXpath);
        public static By BottomLeftArrowButton = By.XPath(LocatorsPath.bottomLeftArrowListOfAssignmentsXpath);
        public static By BottomRightArrowButton = By.XPath(LocatorsPath.bottomRightArrowListOfAssignmentsXpath);
        public static By SearchInputField = By.XPath(LocatorsPath.searchInputXpath);
        public static By DropDownRowButton = By.XPath(LocatorsPath.dropDownButtonXpath);
        public static By ClickToNavbarMenuListOfUnassignedButton = By.XPath(LocatorsPath.clickToNavbarMenuListOfUnassignedXpath);
        public static By FirstPagePagination = By.XPath(LocatorsPath.firstPageXpath);
        public static By LastPagePagination = By.XPath(LocatorsPath.lastPageXpath);
        public static By SortedByName = By.XPath(LocatorsPath.sortedByName);
        public static By SortedBySurname = By.XPath(LocatorsPath.sortedBySurname);
        public static By SortedByEmail = By.XPath(LocatorsPath.sortedByEmail);
        public static By TableData = By.XPath(LocatorsPath.tableData);


        public static By UnassignedUserFirstName(int row) => By.XPath($"//tbody/tr[{row}]/td[1]");
        public static By UnassignedUserLastName(int row) => By.XPath($"//tbody/tr[{row}]/td[2]");
        public static By UnassignedUserEmail(int row) => By.XPath($"//tbody/tr[{row}]/td[3]");
        public static By NavigateToPage(int page) => By.XPath($"//ul[2]/li[{page}]");

    }
}

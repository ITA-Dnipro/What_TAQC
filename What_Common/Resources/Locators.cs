using OpenQA.Selenium;

namespace What_Common.Resources
{
    public class Locators
    {
        public static class CommonLocator
        {
            public static By ClickToNavbarMenu(string page) => By.XPath($"//span[contains(.,'{page}')]");
        }
        public static class ResetPassword
        {
            public static By emailAddressField = By.XPath("//input[@id='email']");
            public static By emailAddressError = By.XPath("//input[@id='email']/following-sibling::div[contains(@class,'text-danger')]");
            public static By newPasswordField = By.XPath("//input[@id='newPassword']");
            public static By newPasswordError = By.XPath("//input[@id='newPassword']/following-sibling::div[contains(@class,'text-danger')]");
            public static By confirmPasswordField = By.XPath("//input[@id='confirmNewPassword']");
            public static By confirmPasswordError = By.XPath("//input[@id='confirmNewPassword']/following-sibling::div[contains(@class,'text-danger')]");
            public static By confirmButton = By.XPath("//button[text()='Confirm']");
            public static By confirmButtonError = By.XPath("//button[text()='Confirm']/../following-sibling::div[contains(@class,'text-danger')]");
            public static By backButton = By.XPath("//button[text()='Back']");
            public static By xButton = By.XPath("//span[@aria-hidden='true']");
        }

        public static class Schedule
        {
            public static By CalendarMenu = By.XPath("//*[@class='schedule__date-input___2glbe']");
            public static By TodayButton = By.XPath("//button[contains(.,'Today')]");
            public static By LeftArrowShedulesButton = By.XPath("//*[@class='schedule__arrow___1kCJf schedule__arrow-left___1WRTh']");
            public static By RightArrowShedulesButton = By.XPath("//*[@class='schedule__arrow___1kCJf']");
            public static By ClickToNavbarMenuSheduleButton = By.XPath("//a[contains(.,'Schedule')]");
            public static By InputDateField = By.XPath("//*[@id='root']//*[@class='schedule__date-input___2glbe']");
            public static By DateText = By.XPath("//*[@class = 'mb-0']");
            public static By StartTableDateCsspath = By.CssSelector(".col:nth-child(1) .text-center:nth-child(2)");
            public static By EndTableDateCsspath = By.CssSelector(".col:nth-child(7) .text-center:nth-child(2)");
        }

        public static class UnassignedUser
        {
            public static By TopLeftArrowButton = By.XPath("//*[@class='row justify-content-between align-items-center mb-3']//*[text()='<']");
            public static By TopRightArrowButton = By.XPath("//*[@class='row justify-content-between align-items-center mb-3']//*[text()='>']");
            public static By BottomLeftArrowButton = By.XPath("//*[@class='row justify-content-between align-items-center mb-3 unassigned-list__paginate___2mqJX']//*[text()='<']");
            public static By BottomRightArrowButton = By.XPath("//*[@class='row justify-content-between align-items-center mb-3 unassigned-list__paginate___2mqJX']//*[text()='>']");
            public static By SearchInputField = By.XPath("//input[@type='text']");
            public static By DropDownRowButton = By.XPath("//select[@id='change-visible-people']");
            public static By ClickToNavbarMenuListOfUnassignedButton = By.XPath("//span[contains(.,'Assignment')]");
            public static By FirstPagePagination = By.XPath("//ul[2]/li");
            public static By LastPagePagination = By.XPath("//ul[2]/li[last()]");
            public static By SortedByName = By.XPath("//th[1]/span");
            public static By SortedBySurname = By.XPath("//th[2]/span");
            public static By SortedByEmail = By.XPath("//th[3]/span");
            public static By TableData = By.XPath("//tbody/tr");

            public static By UnassignedUserFirstName(int row) => By.XPath($"//tbody/tr[{row}]/td[1]");
            public static By UnassignedUserLastName(int row) => By.XPath($"//tbody/tr[{row}]/td[2]");
            public static By UnassignedUserEmail(int row) => By.XPath($"//tbody/tr[{row}]/td[3]");
            public static By NavigateToPage(int page) => By.XPath($"//ul[2]/li[{page}]");
        }
    }
}

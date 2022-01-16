using OpenQA.Selenium;

namespace What_Common.Resources
{
    public class Locators
    {
        public static class CommonLocator
        {
            public static By ClickToNavbarMenu(string page) => By.XPath($"//span[contains(.,'{page}')]");
            public static By DropdownNameElement = By.XPath("//span[contains(@class, \"header__header__dropdown-icon___1CTJ8\")]");
            public static By MyProfile = By.XPath("//a[text()=\"My profile\"]");
            public static By ChangePassword = By.XPath("//a[text()=\"Change password\"]");
            public static By LogOut = By.XPath("//a[text()=\"Log Out\"]");
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

        public static class MyProfilePage
        {
            public static By CHANGE_PWD_BTN = By.XPath("//span[text()=\"Change password\"]");
            public static By FIRST_NAME_FIELD = By.XPath("//div[text()=\"First Name:\"]/following-sibling::div");
            public static By LAST_NAME_FIELD = By.XPath("//div[text()=\"Last Name:\"]/following-sibling::div");
            public static By EMAIL_ADDRESS_FIELD = By.XPath("//div[text()=\"Email address:\"]/following-sibling::div");
        }

        public static class NavBarAsAdmin
        {
            //public const string ICON_LINK = "//a[contains(@href, \"/my-profile\")]";
            public static By ICON_LINK = By.XPath("//span[contains(@class, \"header__header__account-user--fullname___2kSON\")]/preceding-sibling::a");
            public static By DROPDOWN_NAME_ELEMENT = By.XPath("//span[contains(@class, \"header__header__dropdown-icon___1CTJ8\")]");
            public static By MY_PROFILE_LINK = By.XPath("//a[text()=\"My profile\"]");
            public static By CHANGE_PWD_LINK = By.XPath("//a[text()=\"Change password\"]");
            public static By LOG_OUT_LINK = By.XPath("//a[text()=\"Log Out\"]");
        }

        public static class SideBarAsAdmin
        {
            public static By STUDENTS_PAGE_LINK = By.XPath("//a[@data-id=\"0\"]");
            public static By MENTORS_PAGE_LINK = By.XPath("//a[@data-id=\"1\"]");
            public static By SECRETARIES_PAGE_LINK = By.XPath("//a[@data-id=\"2\"]");
            public static By LESSONS_PAGE_LINK = By.XPath("//a[@data-id=\"3\"]");
            public static By GROUPS_PAGE_LINK = By.XPath("//a[@data-id=\"4\"]");
            public static By COURSES_PAGE_LINK = By.XPath("//a[@data-id=\"5\"]");
            public static By SCHEDULES_PAGE_LINK = By.XPath("//a[@data-id=\"6\"]");
            public static By ASSIGNMENTS_PAGE_LINK = By.XPath("//a[@data-id=\"7\"]");
            public static By HOMEWORK_PAGE_LINK = By.XPath("//a[@data-id=\"8\"]");
        }

        public static class ListOfCoursesPage
        {
            public static By PREV_PAGE_BTN = By.XPath("//button[text()=\"<\"]");
            public static By NEXT_PAGE_BTN = By.XPath("//button[text()=\">\"]");
            public static By VIEW_ROWS_BTN = By.XPath("//div[@class='btn-group']/child::button/preceding-sibling::button");
            public static By VIEW_CARDS_BTN = By.XPath("//div[@class='btn-group']/child::button/following-sibling::button");
            public static By SEARCH_FIELD = By.XPath("//input[@placeholder=\"Course`s title\"]");
            public static By DISABLED_COURSES_CHECKBOX = By.XPath("//input[@type=\"checkbox\"]");
            public static By ADD_COURSE_BTN = By.XPath("//span[text()=\"Add a course\"]/..");
            public static By SORT_BY_TITLE_ELEMENT = By.XPath("//span[@data-sorting-param=\"name\"]");
            public static By COURSE_INFO_ELEMENT = By.XPath("//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[text()=\"Soft Skills for Lecturers\"]");
            public static By EDIT_COURSE_ELEMENT = By.XPath("//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[@class=\"text-center\"]");
            public static By DETAILS_IN_CARD_VIEW_BTN = By.XPath("//div[text()=\"Soft Skills for Lecturers\"]/following-sibling::button");
            public static By EDIT_IN_CARD_VIEW_ELEMENT = By.XPath("//div[text()=\"Soft Skills for Lecturers\"]/following-sibling::button/following-sibling::div"); //???

        }

        public static class CourseDetails
        {
            public static By COURSE_DETAILS_TAB = By.XPath("//a[text()=\"Course details\"]");
            public static By EDIT_COURSE_DETAILS_TAB = By.XPath("//a[text()='Edit course details']");
            public static By ARROW_BACK_LINK = By.XPath("//a[contains(@class, 'align-items-center') and @href='/courses']");
        }

        public static class EditCourseDetails
        {
            public static By COURSE_DETAILS_TAB = By.XPath("//a[text()=\"Course details\"]");
            public static By EDIT_COURSE_DETAILS_TAB = By.XPath("//a[text()='Edit course details']");
            public static By ARROW_BACK_LINK = By.XPath("//a[contains(@class, 'align-items-center') and @href='/courses']");
            public static By COURSE_NAME_FIELD = By.XPath("//input[@placeholder='Course name']");
            public static By DISABLE_BTN = By.XPath("//span[text()='Disable']/..");
            public static By MODAL_CANCEL_BTN = By.XPath("//button[text()='Cancel']");
            public static By MODAL_DISABLE_BTN = By.XPath("//button[text()='Disable']");
            public static By RESET_BTN = By.XPath("//button[text()='Reset']");
            public static By SAVE_BTN = By.XPath("//button[text()='Save']");
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
            public static By FirstPagePagination = By.XPath("//ul[2]/li[1]");
            public static By LastPagePagination = By.XPath("//ul[2]/li[last()]");
            public static By SortedByName = By.XPath("//span[text()='Name']");
            public static By SortedBySurname = By.XPath("//span[text()='Surname']");
            public static By SortedByEmail = By.XPath("//span[text()='Email']");
            public static By TableData = By.XPath("//tbody/tr");
            public static By FirstNameTableData = By.XPath("//tbody/tr/td[1]");
            public static By LastNameTableData = By.XPath("//tbody/tr/td[2]");
            public static By EmailTableData = By.XPath("//tbody/tr/td[3]");

            public static By UnassignedUserFirstName(int row) => By.XPath($"//tbody/tr[{row}]/td[1]");
            public static By UnassignedUserLastName(int row) => By.XPath($"//tbody/tr[{row}]/td[2]");
            public static By UnassignedUserEmail(int row) => By.XPath($"//tbody/tr[{row}]/td[3]");
            public static By ChooseRoleAtCurrentRow(int row, int role) => By.XPath($"//tbody/tr[{row}]//option[{role}]");
            public static By ClickToAddRoleButton(int row) => By.XPath($"//tbody/tr[{row}]//button");
        }
    }
}

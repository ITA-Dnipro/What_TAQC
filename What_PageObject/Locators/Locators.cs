namespace SeleniumTest1
{
    public static class Locators
    {
        public static class SignInPage
        {
            public const string LOGIN_FIELD = "//*[@id=\"email\"]";
            public const string PWD_FIELD = "//*[@id=\"password\"]";
            public const string SIGN_IN_BTN = "//button[text()=\"Sign in\"]";
            public const string FORGOT_PWD_LINK = "//a[text()=\"Forgot Password?\"]";
            public const string REGISTRATION_LINK = "//a[text()=\"Registration\"]";
        }

        public static class MyProfilePage
        {
            public const string CHANGE_PWD_BTN = "//span[text()=\"Change password\"]";
            public const string FIRST_NAME_FIELD = "//div[text()=\"First Name:\"]/following-sibling::div";
            public const string LAST_NAME_FIELD = "//div[text()=\"Last Name:\"]/following-sibling::div";
            public const string EMAIL_ADDRESS_FIELD = "//div[text()=\"Email address:\"]/following-sibling::div";
        }

        public static class NavBarAsAdmin
        {
            //public const string ICON_LINK = "//a[contains(@href, \"/my-profile\")]";
            public const string ICON_LINK = "//span[contains(@class, \"header__header__account-user--fullname___2kSON\")]/preceding-sibling::a";
            public const string DROPDOWN_NAME_ELEMENT = "//span[contains(@class, \"header__header__dropdown-icon___1CTJ8\")]";
            public const string MY_PROFILE_LINK = "//a[text()=\"My profile\"]";
            public const string CHANGE_PWD_LINK = "//a[text()=\"Change password\"]";
            public const string LOG_OUT_LINK = "//a[text()=\"Log Out\"]";
        }

        public static class SideBarAsAdmin
        {
            public const string STUDENTS_PAGE_LINK = "//a[@data-id=\"0\"]";
            public const string MENTORS_PAGE_LINK = "//a[@data-id=\"1\"]";
            public const string SECRETARIES_PAGE_LINK = "//a[@data-id=\"2\"]";
            public const string LESSONS_PAGE_LINK = "//a[@data-id=\"3\"]";
            public const string GROUPS_PAGE_LINK = "//a[@data-id=\"4\"]";
            public const string COURSES_PAGE_LINK = "//a[@data-id=\"5\"]";
            public const string SCHEDULES_PAGE_LINK = "//a[@data-id=\"6\"]";
            public const string ASSIGNMENTS_PAGE_LINK = "//a[@data-id=\"7\"]";
            public const string HOMEWORK_PAGE_LINK = "//a[@data-id=\"8\"]";
        }

        public static class ListOfCoursesPage
        {
            public const string PREV_PAGE_BTN = "//button[text()=\"<\"]";
            public const string NEXT_PAGE_BTN = "//button[text()=\">\"]";
            public const string VIEW_ROWS_BTN = "//div[@class='btn-group']/child::button/preceding-sibling::button";
            public const string VIEW_CARDS_BTN = "//div[@class='btn-group']/child::button/following-sibling::button";
            public const string SEARCH_FIELD = "//input[@placeholder=\"Course`s title\"]";
            public const string DISABLED_COURSES_CHECKBOX = "//input[@type=\"checkbox\"]";
            public const string ADD_COURSE_BTN = "//span[text()=\"Add a course\"]/..";
            public const string SORT_BY_TITLE_ELEMENT = "//span[@data-sorting-param=\"name\"]";
            public const string COURSE_INFO_ELEMENT = "//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[text()=\"Soft Skills for Lecturers\"]";
            public const string EDIT_COURSE_ELEMENT = "//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[@class=\"text-center\"]";
            public const string DETAILS_IN_CARD_VIEW_BTN = "//div[text()=\"Soft Skills for Lecturers\"]/following-sibling::button";
            public const string EDIT_IN_CARD_VIEW_ELEMENT = "//div[text()=\"Soft Skills for Lecturers\"]/following-sibling::button/following-sibling::div"; //???

        }

        public static class CourseDetails
        {
            public const string COURSE_DETAILS_TAB = "//a[text()=\"Course details\"]";
            public const string EDIT_COURSE_DETAILS_TAB = "//a[text()='Edit course details']";
            public const string ARROW_BACK_LINK = "//a[contains(@class, 'align-items-center') and @href='/courses']";
        }

        public static class EditCourseDetails
        {
            public const string COURSE_DETAILS_TAB = "//a[text()=\"Course details\"]";
            public const string EDIT_COURSE_DETAILS_TAB = "//a[text()='Edit course details']";
            public const string ARROW_BACK_LINK = "//a[contains(@class, 'align-items-center') and @href='/courses']";
            public const string COURSE_NAME_FIELD = "//input[@placeholder='Course name']";
            public const string DISABLE_BTN = "//span[text()='Disable']/..";
            public const string MODAL_CANCEL_BTN = "//button[text()='Cancel']";
            public const string MODAL_DISABLE_BTN = "//button[text()='Disable']";
            public const string RESET_BTN = "//button[text()='Reset']";
            public const string SAVE_BTN = "//button[text()='Save']";
        }
    }
}

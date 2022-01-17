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

        public static class MyProfilePage
        {
            public static By ChangePasswordButton = By.XPath("//span[text()=\"Change password\"]");
            public static By FirstNameField = By.XPath("//div[text()=\"First Name:\"]/following-sibling::div");
            public static By LastNameField = By.XPath("//div[text()=\"Last Name:\"]/following-sibling::div");
            public static By EmailAddressField = By.XPath("//div[text()=\"Email address:\"]/following-sibling::div");
        }

        public static class NavBar
        {
            //public const string ICON_LINK = "//a[contains(@href, \"/my-profile\")]";
            public static By IconLink = By.XPath("//span[contains(@class, \"header__header__account-user--fullname___2kSON\")]/preceding-sibling::a");
            public static By DropDownNameElement = By.XPath("//span[contains(@class, \"header__header__dropdown-icon___1CTJ8\")]");
            public static By MyProfileLink = By.XPath("//a[text()=\"My profile\"]");
            public static By ChangePasswordLink = By.XPath("//a[text()=\"Change password\"]");
            public static By LogOutLink = By.XPath("//a[text()=\"Log Out\"]");
        }

        public static class SideBar
        {
            public static By StudentPageLink = By.XPath("//a[@data-id=\"0\"]");
            public static By MentorPageLink = By.XPath("//a[@data-id=\"1\"]");
            public static By SecretariesPageLink = By.XPath("//a[@data-id=\"2\"]");
            public static By LessonsPageLink = By.XPath("//a[@data-id=\"3\"]");
            public static By GroupsPageLink = By.XPath("//a[@data-id=\"4\"]");
            public static By CoursesPageLink = By.XPath("//a[@data-id=\"5\"]");
            public static By SchedulesPageLink = By.XPath("//a[@data-id=\"6\"]");
            public static By AssignmentPageLink = By.XPath("//a[@data-id=\"7\"]");
            public static By HomeworkPageLink = By.XPath("//a[@data-id=\"8\"]");
        }

        public static class ListOfCoursesPage
        {
            public static By PreviousButtonPage = By.XPath("//button[text()=\"<\"]");
            public static By NextButtonPage = By.XPath("//button[text()=\">\"]");
            public static By ViewRowsButton = By.XPath("//div[@class='btn-group']/child::button/preceding-sibling::button");
            public static By ViewCardsButton = By.XPath("//div[@class='btn-group']/child::button/following-sibling::button");
            public static By SearchField = By.XPath("//input[@placeholder=\"Course`s title\"]");
            public static By DisabledCoursesCheckbox = By.XPath("//input[@type=\"checkbox\"]");
            public static By AddCourseButton = By.XPath("//span[text()=\"Add a course\"]/..");
            public static By SortByTitleElement = By.XPath("//span[@data-sorting-param=\"name\"]");
            public static By CourseTableInRow = By.XPath("//table");
            public static By CourseTableInCards = By.XPath("//div[@class='container d-flex flex-wrap']");
            //TODO remake locator below
            public static By CourseDetailsInRowElement = By.XPath("//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[text()=\"Soft Skills for Lecturers\"]");
            public static By EditCourseElement = By.XPath("//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[@class=\"text-center\"]");
            public static By EditInCardViewButton = By.XPath("//div[text()=\"Soft Skills for Lecturers\"]/following-sibling::button/following-sibling::div"); //???
            
            public static By DetailsInCardViewButton(int id) => By.XPath($"//div[@class='container d-flex flex-wrap']/child::div[{id}]/descendant::button");

        }

        public static class CourseDetails
        {
            public static By CourseName = By.XPath("//div[@class='container']/descendant::div[@class='row']/child::div[@class='col-12 col-md-6']/span");
            public static By CourseDetailsTab = By.XPath("//a[text()=\"Course details\"]");
            public static By EditCourseDetailsTab = By.XPath("//a[text()='Edit course details']");
            public static By ArrowBackLink = By.XPath("//a[contains(@class, 'align-items-center') and @href='/courses']");
        }

        public static class EditCourseDetails
        {
            public static By CourseDetailsTab = By.XPath("//a[text()=\"Course details\"]");
            public static By EditCourseDetailsTab = By.XPath("//a[text()='Edit course details']");
            public static By ArrowBackLink = By.XPath("//a[contains(@class, 'align-items-center') and @href='/courses']");
            public static By CourseNameField = By.XPath("//input[@placeholder='Course name']");
            public static By DisableButton = By.XPath("//span[text()='Disable']/..");
            public static By ModalCancelButton = By.XPath("//button[text()='Cancel']");
            public static By ModalDisableButton = By.XPath("//button[text()='Disable']");
            public static By ResetButton = By.XPath("//button[text()='Reset']");
            public static By Save_button = By.XPath("//button[text()='Save']");
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

        public static class SignIn
        {
            public static readonly By SignInButton = By.XPath("//*[@class='btn button__default___3hOmG button__button___24ZfP auth__form-button___3KEpa']");
            public static readonly By EmailField = By.XPath("//*[@id='email']");
            public static readonly By PasswordField = By.XPath("//*[@id='password']");
            public static readonly By RegistrationButton = By.XPath("//*[contains(text(),'Registration')]");
            public static readonly By ForgotPasswordButton = By.XPath("//*[contains(text(),'Forgot Password?')]");
        }

        public static class Students
        {
            public static readonly By UploadStudent = By.XPath("//*[contains(text(),'Upload student')]");
            public static readonly By AddStudentButton = By.XPath("//*[contains(text(),'Add a student')]");
            public static readonly By DisabledStudents = By.XPath("//*[contains(text(),'Disabled students')]");
            public static readonly By SortByName = By.XPath("//*[contains(text(),'Name')]");
            public static readonly By SortBySurname = By.XPath("//*[contains(text(),'Surname')]");
            public static readonly By SortByEmail = By.XPath("//*[contains(text(),'Email')]");
        }
    }
}

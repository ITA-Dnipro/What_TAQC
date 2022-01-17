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

        public static class ForgotPassword
        {
            public static By
                forgotPasswordLabel = By.XPath("//*[contains(text(),'Forgot your password?')]"),
                emailAddressField = By.XPath("//input[@id='email']"),
                emailAddressError = By.XPath("//*[@class='text-danger mt-2']"),
                sendButton = By.XPath("//button[text()='Send']"),
                sendButtonError = By.XPath("//*[@class='text-center text-danger mt-2']"),
                backButton = By.XPath("//button[text()='Back']"),
                xButton = By.XPath("//span[@aria-hidden='true']"),
                forgotPasswordLink = By.XPath("//*[contains(text(),'Forgot Password?')]"),
                modalWindowText = By.XPath("//*[@class='modal-window__modal-body___3v1gd modal-body']");
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
        public static class ListOfSecretaryPage
        {
            public static By
                cardsButton = By.XPath("//div[@class='btn-group']/child::button/following-sibling::button"),
                //tableButton = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/div/div[1]/div/button[1]"),
                searchField = By.XPath("//input[@placeholder=\"Secretary`s name\"]"),
                paginationArrowLeftInTop = By.XPath("//button[text()=\"<\"]"),
                paginationArrowRightInTop = By.XPath("//button[text()=\">\"]"),
                paginationArrowLeftInBottom = By.XPath("//button[text()=\"<\"]"),
                paginationArrowRightInBottom = By.XPath("//button[text()=\">\"]"),
                rowsSelected = By.XPath("//div[@class='btn-group']/child::button/preceding-sibling::button"),
                disabledCheckbox = By.XPath("//input[@type=\"checkbox\"]"),
                addButton = By.XPath("//span[text()=\"Add a secretary\"]/.."),
                sortByName = By.XPath("//span[@data-sorting-param=\"name\"]"),
                sortBySurname = By.XPath("//span[@data-sorting-param=\"surname\"]"),
                sortByEmail = By.XPath("//span[@data-sorting-param=\"email\"]"),
                detailsButtonTable = By.XPath("//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[text()=\"john.williams@example.com\"]"),
                detailsButtonCards = By.XPath("//div[text()=\"john.williams@example.com\"]/following-sibling::button"),
                editButtonInCards = By.XPath("//div[text()=\"john.williams@example.com\"]/following-sibling::button/following-sibling::div"),
                editButtonInTable = By.XPath("//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[@class=\"text-center\"]");
                //secretaryNotFoundError = By.XPath("//*[@id=\"root\"]/div/div/div[2]/div[1]/table/tbody/tr/td"),
                //elementsInTable = By.XPath("//tr[@class = 'list-of-lessons__table-row___16_kJ
        }
        public static class SecretaryDetails
        {
            public static By
                detailsTab = By.XPath("//a[text()=\"Secretary's details\"]"),
                editDetailsTab = By.XPath("//a[text()='Edit secretary']"),
                arrowBackButton = By.XPath("//a[contains(@class, 'align-items-center') and @href='/secretaries']");
                //firstNameLink = By.XPath("//input[@placeholder='First Name:']"),
                //lastNameLink = By.XPath("//input[@placeholder='Last Name:']"),
                //emailLink = By.XPath("//input[@placeholder='Email:']");
        }

        public static class EditSecretaryDetails
        {
            public static By
                detailsTab = By.XPath("//a[text()=\"Secretary's details\"]"),
                editDetailsTab = By.XPath("//a[text()='Edit secretary']"),
                arrowBackButton = By.XPath("//a[contains(@class, 'align-items-center') and @href='/secretaries']"),
                firstNameField = By.XPath("//input[@placeholder='First Name']"),
                lastNameField = By.XPath("//input[@placeholder='Last Name']"),
                emailField = By.XPath("//input[@placeholder='Email']"),
                layOffButton = By.XPath("//button[text()='Lay off']"),
                resetButton = By.XPath("//button[text()='Reset']"),
                saveButton = By.XPath("//button[text()='Save']");
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
            public static By CourseTable = By.XPath("//table");
            public static By CourseDetailsInRowElement = By.XPath("//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[text()=\"Soft Skills for Lecturers\"]");
            public static By EditCourseElement = By.XPath("//tbody[@class=\"table__table-body___bYZbU\"]/descendant::td[@class=\"text-center\"]");
            public static By DetailsInCardViewButton = By.XPath("//div[text()=\"Soft Skills for Lecturers\"]/following-sibling::button");
            public static By EditInCardViewButton = By.XPath("//div[text()=\"Soft Skills for Lecturers\"]/following-sibling::button/following-sibling::div"); //???

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
		
		public static class SignIn
        {
            public static readonly By SignInButton = By.XPath("//*[@class='btn button__default___3hOmG button__button___24ZfP auth__form-button___3KEpa']");
            public static readonly By EmailField = By.XPath("//*[@id='email']");
            public static readonly By PasswordField = By.XPath("//*[@id='password']");
            public static readonly By RegistrationButton = By.XPath("//*[contains(text(),'Registration')]");
            public static readonly By ForgotPasswordButton = By.XPath("//*[contains(text(),'Forgot Password?')]");
        }
        public static class RegistrationPage
        {
            public static By FirstNameField = By.XPath("//*[@id=\"firstName\"]");
            public static By LastNameField = By.XPath("//*[@id=\"lastName\"]");
            public static By EmailAdressField = By.XPath("//*[@id=\"email\"]");
            public static By PasswordField = By.XPath("//*[@id=\"password\"]");
            public static By ConfirmPasswordField = By.XPath("//*[@id=\"confirm-password\"]");
            public static By SignUpButton = By.XPath("//button[text()='Sign up']");
            public static By Registration = By.XPath("//*[contains(text(),'Registration')]");
            public static By NamePageRegistration = By.XPath("//*[@class='modal-content']");
            public static By BackButton = By.XPath("//button[text()='Back']");
            public static By ErrorField = By.XPath("//*[contains(text(),'This field is required')]");
            
        }
        public static class Students
        {
            public static readonly By CardsIcon = By.XPath("//*[href='/assets/svg/Card.svg#Card']");
            public static readonly By ListIcon = By.XPath("//*[href ='/assets/svg/List.svg#List']");
            public static readonly By UploadStudent = By.XPath("//*[contains(text(),'Upload student')]");
            public static readonly By AddStudentButton = By.XPath("//*[contains(text(),'Add a student')]");
            public static readonly By DisabledStudents = By.XPath("//*[contains(text(),'Disabled students')]");
            public static readonly By SortByName = By.XPath("//*[contains(text(),'Name')]");
            public static readonly By SortBySurname = By.XPath("//*[contains(text(),'Surname')]");
            public static readonly By SortByEmail = By.XPath("//*[contains(text(),'Email')]");
            public static readonly By ListElement = By.XPath("//tbody/tr");
            public static readonly By DetailsButton = By.XPath("//div[@class='container d-flex flex-wrap']/child::div[1]/descendant::button");
            public static readonly By ListTable = By.XPath("//div[@class='col-12 card shadow p-3 mb-5 bg-white ml-2 mr-2']");
        }
	public static class Lessons
        {
            public static By AddLessonButton = By.XPath("//button[contains(.,'Add a lesson')]");
            public static By AddThemeButton = By.CssSelector(".btn-warning");
            public static By FilterButton = By.XPath("//button[contains(.,'Filter')]");
            public static By SearchInput = By.CssSelector(".search__searchInput___34nMl");
            public static By ListViewButton = By.XPath("//button[@class='btn btn-secondary']//*[contains(@href, 'List')]");
            public static By CardViewButton = By.XPath("//button[@class='btn btn-secondary']//*[contains(@href, 'Card')]");
            public static By ThemaNameTableHead = By.XPath("//span[text()='themeName']");
            public static By LessonDataTableHead = By.XPath("//span[text()='lessonDate']");
            public static By LessonTimeTableHead = By.XPath("//span[text()='lessonTime']");
            public static By EditPencilTableHead = By.XPath("//td[@class = 'text-center']");
            public static By LessonsTable = By.XPath("//table[@class='table table-hover']");
            public static By PageTitle = By.XPath("//h2[text()='Lessons']");
            public static By StartDatePicker = By.XPath("//input[@id='startDate']");
            public static By FinishDatePicker = By.XPath("//input[@id='finishDate']");
            public static By AlertFlashMessage = By.XPath("//div[@role = 'alert']");
            public static By RowsOnTable = By.XPath("//select[@id='change-visible-people']");
            public static By MaxRowsOnTable = By.XPath("//option[normalize-space()='99']");
            public static By LessonsThemas = By.XPath("//tbody/tr/td[1]");
            public static By EditIcon(int row) => By.XPath($"//tbody/tr[{row}]/td[4]");
            public static By ClickOnLessons(string name) => By.XPath($"//td[normalize-space()='{name}']");
            public static By ClickOnEditLesson(string name) => By.XPath($"//td[normalize-space()='{name}']/following-sibling::td[contains(@class,'text-center')]");
        }
	public static class AddLesson
        {
            public static By LessonThemeField = By.XPath("//input[@id='inputLessonTheme']");
            public static By LessonThemeError = By.XPath("//div[@class='add-lesson__error___2dTXe']");
            public static By GroupNameField = By.XPath("//input[@id='inputGroupName']");
            public static By GroupNameError = By.XPath("//div[@id='group-error']");
            public static By LessonsDate = By.XPath("//input[@id='choose-date-time']");
            public static By MentorEmailField = By.XPath("//input[@id='mentorEmail']");
            public static By MentorEmailError = By.XPath("//div[@id='mentor-error']");
            public static By ClassRegisterButton = By.XPath("//button[@id='class-register-btn']");
            public static By CancelButton = By.XPath("//button[normalize-space()='Cancel']");
            public static By MainForm = By.XPath("//form[@id='form']");
            public static By AddLessonLabel = By.XPath("//h3[normalize-space()='Add a Lesson']");
            public static By SaveButton = By.XPath("//button[@id='submit']");
            public static By Groups = By.XPath("//datalist[@id='group-list']/option");
            public static By Mentors = By.XPath("//datalist[@id='mentor-list']/option");

        }
	public static class LessonDetails
        {
            public static By MainLabel = By.XPath("//h3[normalize-space()='Lesson details']");
            public static By LessonsTheme = By.XPath("//span[normalize-space()='Lesson Theme:']/../following-sibling::div[contains(@class,'col-sm-6')]");
            public static By LessonsDate = By.XPath("//span[normalize-space()='Lesson Date:']/../following-sibling::div[contains(@class,'col-sm-6')]");
            public static By LessonsTime = By.XPath("//span[normalize-space()='Lesson Time:']/../following-sibling::div[contains(@class,'col-sm-6')]");
            public static By MentorName= By.XPath("//span[normalize-space()='Mentor name:']/../following-sibling::div[contains(@class,'col-sm-6')]");
            public static By GroupName = By.XPath("//span[normalize-space()='Group name:']/../following-sibling::div[contains(@class,'col-sm-6')]");
            public static By AllStudentsName = By.XPath("//tbody/tr/td[1]");
            public static By CancelButton = By.XPath("//button[normalize-space()='Cancel']");
        }
	 public static class EditLesson
        {
            public static By GroupNameField = By.XPath("//input[@id='inputGroupName']");
            public static By LessonThemeField = By.XPath("//input[@id='inputLessonTheme']");
            public static By SaveButton = By.XPath("//button[contains(@data-testid,'submitBtn')]");
        }
    }
}

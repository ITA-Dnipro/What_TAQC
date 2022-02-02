using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.Course
{
    public class AddCoursePage : BasePage
    {
        private Waiter waiter;
        public AddCoursePage()
        {
            this.waiter = new Waiter(Driver.Current);
        }

        /// <summary>
        /// Canceling all changes and redirect to Course Page
        /// </summary>
        /// <returns>Course Page</returns>
        public CoursesPage ClickCancelButton()
        {
            ClickElement(Locators.AddCourse.CancelButton);
            WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow);
            return new CoursesPage();
        }

        /// <summary>
        /// Add new course to database redirect to Course Page and show flash message
        /// </summary>
        /// <returns>Course Page</returns>
        public CoursesPage ClickSaveButton()
        {
            ClickElement(Locators.AddCourse.SaveButton);
            WaitUntilElementLoads<CoursesPage>(Locators.ListOfCoursesPage.CourseTableInRow);
            return new CoursesPage();
        }

        /// <summary>
        /// Fill textbox
        /// </summary>
        /// <returns></returns>
        public AddCoursePage FillTextBox(string courseName)
        {
            FillField(Locators.AddCourse.CourseNameField, courseName);
            return this;
        }
    }
}
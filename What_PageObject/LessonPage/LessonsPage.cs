using NUnit.Framework;
using OpenQA.Selenium;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.Lessons
{
    public class LessonsPage : BasePageWithSideBar
    {
        List<IWebElement> tableRows = new List<IWebElement>();


        public AddLessonPage ClickAddLessonButton()
        {
            ClickElement(Locators.Lessons.AddLessonButton);
            return new AddLessonPage();
        }
        private List<IWebElement> GetAllTableRows()
        {

            tableRows.AddRange(Driver.Current.FindElements(By.XPath(@"//tbody/tr")));

            return tableRows;
        }
        public LessonsDetailsPage ClickOnLesson(int id, out (string themeName, string lessonsDate, string lessonsTime) selectedRow )
        {
            GetAllTableRows();
            if (tableRows.Count > id)
            {
                selectedRow.themeName = tableRows[id].FindElement(By.XPath("//td[1]")).Text;
                selectedRow.lessonsDate = tableRows[id].FindElement(By.XPath("//td[2]")).Text;
                selectedRow.lessonsTime = tableRows[id].FindElement(By.XPath("//td[3]")).Text;
                ClickElement(By.CssSelector($"tbody tr:nth-child({id}) td:nth-child(1)"));
                
            }
            else
            {
                selectedRow.themeName = "";
                selectedRow.lessonsDate = "";
                selectedRow.lessonsTime = "";
            }

            return new LessonsDetailsPage();
        }
        public LessonsDetailsPage ClickOnLesson(string name)
        {
            ClickElement(Locators.Lessons.ClickOnLessons(name));

            return new LessonsDetailsPage() ;
        }
      
        public EditLessonPage ClicOnEditLesson(int onRow)
        {
            ClickElement(Locators.Lessons.EditIcon(onRow));
            return new EditLessonPage();
        }
        public EditLessonPage ClicOnEditLesson(string onRow)
        {
            ChangeRowsToMax();
            ClickElement(Locators.Lessons.ClickOnEditLesson(onRow));
            return new EditLessonPage();
        }
        public LessonsPage VerifyFlashMessage()
        {
            string expected = "×\r\nClose alert\r\nThe lesson has been added successfully!";
            string actual = Driver.Current.FindElement(Locators.Lessons.AlertFlashMessage).Text;
            Assert.AreEqual(expected, actual);
            return this;
        }
      
        public LessonsPage VerifyLessonAddedToTable(string lessonTheme)
        {
            ChangeRowsToMax();

            List<string> lessonsThemeOnTable = new List<string>(
                Driver.Current.FindElements(Locators.Lessons.LessonsThemas)
                .Select(x => x.Text));

            Assert.IsTrue(lessonsThemeOnTable.Contains<string>(lessonTheme));
            return this;
        }
        private void ChangeRowsToMax()
        {
            ClickElement(Locators.Lessons.RowsOnTable);
            ClickElement(Locators.Lessons.MaxRowsOnTable);
        }
        public LessonsPage VerifyFlashMessageAppear()
        {
            string expected = "×\r\nClose alert\r\nThe lesson has been edited successfully";
            string actual = Driver.Current.FindElement(By.XPath("//div[@role='alert']")).Text;
            Assert.AreEqual(expected, actual);
            return this;
        }

    }
}

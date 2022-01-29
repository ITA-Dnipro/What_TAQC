using NUnit.Framework;
using OpenQA.Selenium;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.LessonPage.Models;

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
            tableRows.AddRange(Driver.Current.FindElements(Locators.Lessons.TableRows));
            return tableRows;
        }
        public LessonsDetailsPage ClickOnRandomLesson(out LessonRow selectedRow )
        {
            GetAllTableRows();
            selectedRow = new LessonRow();
            Random rand = new Random();
            int clickedRowId = rand.Next(tableRows.Count);
            if (tableRows.Count > 0)
            {
                selectedRow.ThemeName = tableRows[clickedRowId].FindElement(Locators.Lessons.ClickOnLessonsByPosition(clickedRowId, 1)).Text;
                selectedRow.LessonDate = tableRows[clickedRowId].FindElement(Locators.Lessons.ClickOnLessonsByPosition(clickedRowId, 2)).Text;
                selectedRow.LessonTime = tableRows[clickedRowId].FindElement(Locators.Lessons.ClickOnLessonsByPosition(clickedRowId, 3)).Text;
                ClickElement(Locators.Lessons.ClickOnLessonsByPosition(clickedRowId, 1));
            }
            return new LessonsDetailsPage();
        }
        public LessonsPage SaveClickedRow(string name, out LessonRow selectedRow)
        {
            ChangeRowsToMax();
            selectedRow = new LessonRow();
            selectedRow.ThemeName = Driver.Current.FindElement(Locators.Lessons.LessonInTableByName(name)).Text;
            selectedRow.LessonDate = Driver.Current.FindElement(Locators.Lessons.LessonInTableByNameAndColumn(name, 2)).Text;
            selectedRow.LessonTime = Driver.Current.FindElement(Locators.Lessons.LessonInTableByNameAndColumn(name, 3)).Text;
            return new LessonsPage() ;
        }
        public EditLessonPage ClicOnEditLesson(int onRow)
        {
            ClickElement(Locators.Lessons.EditIconByRow(onRow));
            return new EditLessonPage();
        }
        public EditLessonPage ClicOnEditLesson(string onRow)
        {
            ClickElement(Locators.Lessons.EditLessonByName(onRow));
            return new EditLessonPage();
        }
        public LessonsPage VerifyFlashMessage()
        {
            string expected = "×\r\nClose alert\r\nThe lesson has been added successfully!";
            string actual = Driver.Current.FindElement(Locators.Lessons.LessonsAddedFlashMessage).Text;
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
            string actual = Driver.Current.FindElement(Locators.Lessons.LessonsEditedFlashMessage).Text;
            Assert.AreEqual(expected, actual);
            return this;
        }
        public LessonsDetailsPage ClickOnLesson(string str)
        {
            ChangeRowsToMax();
            ClickElement(Locators.Lessons.LessonInTableByName(str));
            return new LessonsDetailsPage();
        }
    }
}

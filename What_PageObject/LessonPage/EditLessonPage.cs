using NUnit.Framework;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.LessonPage.Models;

namespace What_PageObject.Lessons
{
    public class EditLessonPage : BasePage
    {
        public EditLessonPage VerifyGroupNameFieldDisabled()
        {
            bool isGroupNameFieldEnable = Driver.Current.FindElement(Locators.EditLesson.GroupNameField).Enabled;
            Assert.IsFalse(isGroupNameFieldEnable);
            return this;
        }
        public EditLessonPage VerifyAllInputs(LessonRow expected)
        {
            string lessonTheme = Driver.Current.FindElement(Locators.EditLesson.LessonThemeField).GetAttribute("value");
            string lessonDateTime = Driver.Current.FindElement(Locators.EditLesson.LessonsDateTime).GetAttribute("value");
            string expectedDateTime = expected.LessonDate.Split('.').Reverse().Aggregate((x, y) => x + '-' + y);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected.ThemeName, lessonTheme);
                Assert.AreEqual(expectedDateTime +'T'+ expected.LessonTime, lessonDateTime);
            });
            return this;
        }
        public EditLessonPage VerifyClassJournalExist()
        {
            int classJournalRows = Driver.Current.FindElements(Locators.EditLesson.ClassJournalTable).Count;
            int minSizeStudentInGroup = 1;
            Assert.GreaterOrEqual(classJournalRows, minSizeStudentInGroup);
            return this;
        }
        public EditLessonPage EditLessonTheme(string newLessonTheme)
        {
            FillField(Locators.EditLesson.LessonThemeField, newLessonTheme);
            return this;
        }
        public LessonsPage ClickSaveButton()
        {
            ClickElement(Locators.EditLesson.SaveButton);
            return new LessonsPage();
        }
        public EditLessonPage SaveAllDataFromEditLesson(out LessonEditDetails lessonsDetailsModel)
        {
            lessonsDetailsModel = new LessonEditDetails();
            lessonsDetailsModel.LessonTheme = Driver.Current.FindElement(Locators.EditLesson.LessonThemeField).GetAttribute("value");
            lessonsDetailsModel.GroupName = Driver.Current.FindElement(Locators.EditLesson.GroupNameField).GetAttribute("value");
            lessonsDetailsModel.LessonsDateTime = Driver.Current.FindElement(Locators.EditLesson.LessonsDateTime).GetAttribute("value");

            lessonsDetailsModel.Students = new List<string>(Driver.Current.FindElements(Locators.LessonDetails.AllStudentsName).Select(x => x.Text));
            return new EditLessonPage();
        }
    }
}

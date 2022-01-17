using NUnit.Framework;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.Lessons
{
    public class EditLessonPage :BasePage
    {
        public EditLessonPage VerifyGroupNameFieldDisabled()
        {
            bool isGroupNameFieldEnable = Driver.Current.FindElement(Locators.EditLesson.GroupNameField).Enabled;
            Assert.IsFalse(isGroupNameFieldEnable);
            return this;
        }
        public EditLessonPage EditLessonThemeField()
        {
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
    }
}

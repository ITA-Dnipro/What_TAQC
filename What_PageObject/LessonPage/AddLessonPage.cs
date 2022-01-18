using What_Common.Resources;
using What_Common.DriverManager;
using NUnit.Framework;
using OpenQA.Selenium;

namespace What_PageObject.Lessons
{
    public class AddLessonPage : BasePageWithSideBar
    {
        List<IWebElement> listOfGroups = new List<IWebElement>();
        List<IWebElement> listOfMentorsEmails = new List<IWebElement>();
        public AddLessonPage FillLessonTheme(string theme)
        {
            FillField(Locators.AddLesson.LessonThemeField, theme);
            LooseFocusFromInput();
            return this;
        }
        public AddLessonPage FillGroupName(string groupName)
        {
            FillField(Locators.AddLesson.GroupNameField, groupName);
            LooseFocusFromInput();
            return this;
        }
        public AddLessonPage FillGroupName()
        {
            listOfGroups.AddRange(Driver.Current.FindElements(Locators.AddLesson.Groups));
            if (listOfGroups.Count > 0)
            {
                Random rand = new Random();
                int randomGroupFromList = rand.Next(0, listOfGroups.Count);
                FillGroupName(listOfGroups[randomGroupFromList].GetAttribute("value"));
            }
            return this;
        }
        public AddLessonPage FillLessonDate(string lessonDate)
        {
            Driver.Current.FindElement(Locators.AddLesson.LessonsDate).SendKeys(lessonDate);

            return this;
        }
        public AddLessonPage FillLessonDate()

        {
            string currentTime = DateTime.Now.AddHours(-1).ToString("ddMMyyyyHHmm");

            Driver.Current.FindElement(Locators.AddLesson.LessonsDate).SendKeys(currentTime);

            return this;
        }
        public AddLessonPage FillMentorEmail(string email)
        {
            FillField(Locators.AddLesson.MentorEmailField, email);
            LooseFocusFromInput();
            return this;
        }
        public AddLessonPage FillMentorEmail()
        {
            listOfMentorsEmails.AddRange(Driver.Current.FindElements(Locators.AddLesson.Mentors));
            if (listOfMentorsEmails.Count > 0)
            {
                Random rand = new Random();
                int randomEmailFromList = rand.Next(0, listOfMentorsEmails.Count);
                FillMentorEmail(listOfMentorsEmails[randomEmailFromList].GetAttribute("value"));
            }
            return this;
        }
        public AddLessonPage ClickClassRegisterButton()
        {
            ClickElement(Locators.AddLesson.ClassRegisterButton);
            return this;
        }
        public AddLessonPage VerifyLessonsThemeError(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.AddLesson.LessonThemeError).Text;
            Assert.AreEqual(expected, actual);
            return this;
        }
        public AddLessonPage VerifyGroupNameError(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.AddLesson.GroupNameError).Text;
            Assert.AreEqual(expected, actual);
            return this;
        }
        public AddLessonPage VerifyMentorEmailError(string expected)
        {
            string actual = Driver.Current.FindElement(Locators.AddLesson.MentorEmailError).Text;
            Assert.AreEqual(expected, actual);
            return this;
        }
        public LessonsPage ClickSaveButton()
        {
            ClickElement(Locators.AddLesson.SaveButton);
            return new LessonsPage();
        }
        private void LooseFocusFromInput()
        {
            ClickElement(Locators.AddLesson.AddLessonLabel);
        }
    }
}

using NUnit.Framework;
using What_Common.DriverManager;
using What_Common.Resources;
using What_PageObject.LessonPage.Models;

namespace What_PageObject.Lessons
{
    public class LessonsDetailsPage :BasePageWithSideBar
    {
        public LessonsDetailsPage VerifyAllFields(LessonRow expected)
        {
            string actualTheme = Driver.Current.FindElement(Locators.LessonDetails.LessonsTheme).Text;
            string actualDate = Driver.Current.FindElement(Locators.LessonDetails.LessonsDate).Text;
            string actualTime = Driver.Current.FindElement(Locators.LessonDetails.LessonsTime).Text;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected.ThemeName, actualTheme);
                Assert.AreEqual(expected.LessonDate, actualDate);
                Assert.AreEqual(expected.LessonTime, actualTime);
            });
            return this;
        }
        public LessonsDetailsPage SaveAllDataFromLessonDetails(out LessonsDetailsModel lessonsDetailsModel)
        {
            lessonsDetailsModel = new LessonsDetailsModel();
            lessonsDetailsModel.LessonTheme = Driver.Current.FindElement(Locators.LessonDetails.LessonsTheme).Text;
            lessonsDetailsModel.MentorName = Driver.Current.FindElement(Locators.LessonDetails.MentorName).Text;
            lessonsDetailsModel.GroupName = Driver.Current.FindElement(Locators.LessonDetails.GroupName).Text;
            lessonsDetailsModel.LessonDate = Driver.Current.FindElement(Locators.LessonDetails.LessonsDate).Text;
            lessonsDetailsModel.LessonTime = Driver.Current.FindElement(Locators.LessonDetails.LessonsTime).Text;
            lessonsDetailsModel.StudentsNames = new List<string>(Driver.Current.FindElements(Locators.LessonDetails.AllStudentsName).Select(x => x.Text));
            return new LessonsDetailsPage();
        }
        public LessonsDetailsPage VerifyPageEdited(LessonEditDetails expected, LessonsDetailsModel actual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected.LessonTheme , actual.LessonTheme);
                Assert.AreEqual(expected.GroupName, actual.GroupName);
               // CollectionAssert.AreEqual(expected.Students, actual.StudentsNames);
            });
            return this;
        }
        public LessonsPage ClickCancelButton()
        {
            ClickElement(Locators.LessonDetails.CancelButton);
            return new LessonsPage();
        }
    }
}

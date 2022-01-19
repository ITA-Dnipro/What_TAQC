using NUnit.Framework;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.Lessons
{
    public class LessonsDetailsPage : BasePageWithSideBar
    {
        public LessonsDetailsPage VerifyAll((string lessonsTheme, string lessonsDate, string lessonsTime) expected)
        {
            string actualTheme = Driver.Current.FindElement(Locators.LessonDetails.LessonsTheme).Text;
            string actualDate = Driver.Current.FindElement(Locators.LessonDetails.LessonsDate).Text;
            string actualTime = Driver.Current.FindElement(Locators.LessonDetails.LessonsTime).Text;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected.lessonsTheme, actualTheme);
                Assert.AreEqual(expected.lessonsDate, actualDate);
                Assert.AreEqual(expected.lessonsTime, actualTime);
            });
            return this;
        }
        
       
        public LessonsDetailsPage GetAllData(out LessonsDetailsModel lessonsDetailsModel)
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
        public void VerifyPageEdited(LessonsDetailsModel expected, LessonsDetailsModel actual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected.GroupName , actual.GroupName);
                Assert.AreEqual(expected.MentorName, actual.MentorName);
                Assert.AreEqual(expected.LessonDate, actual.LessonDate);
                Assert.AreEqual(expected.LessonTime, actual.LessonTime);
                CollectionAssert.AreEqual(expected.StudentsNames, actual.StudentsNames);
            });
        }
        public LessonsPage ClickCancelButton()
        {
            ClickElement(Locators.LessonDetails.CancelButton);
            return new LessonsPage();
        }
    }
}

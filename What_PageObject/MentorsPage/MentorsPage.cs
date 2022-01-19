using NUnit.Framework;
using OpenQA.Selenium;
using What_Common.DriverManager;
using What_Common.Resources;

namespace What_PageObject.MentorsPage
{
    public class MentorsPage : BasePageWithSideBar
    {
        public MentorsPage ClickOnSideBar()
        {
            ClickElement(Locators.Mentors.MentorsButtonOnSideBar);
            return this;
        }
        public MentorsPage ClickMentorInTable()
        {
            ClickElement(Locators.Mentors.TableMentors);
            return this;
        }
        public MentorsPage ClickEditMentorPage()
        {
            ClickElement(Locators.Mentors.EditMentorButton);
            return this;
        }
        public MentorsPage VerifyMentorsPage(string expectedPage)
        {
            string actualPage = Driver.Current.FindElement(Locators.Mentors.MentorPage).Text;
            Assert.AreEqual(expectedPage, actualPage);
            return this;
        }
        public MentorsPage VerifyMentorDetails(string expectedField)
        {
            string actualField = Driver.Current.FindElement(Locators.Mentors.MentorDetailsField).Text; 
            Assert.AreEqual(expectedField, actualField);
            return this;
        }
        public MentorsPage VerifyEditMentorPage(string expectedNameField)
        {
            string actualNameField = Driver.Current.FindElement(Locators.Mentors.MentorEditingField).Text;
            Assert.AreEqual(expectedNameField, actualNameField);
            return this;
        }
    }
}

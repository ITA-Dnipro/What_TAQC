using NUnit.Framework;
using What_Common.Resources;

namespace What_PageObject.SchedulesPage
{
    public class SchedulePage : BasePageWithSideBar
    {
        public SchedulePage ClickNextDateButton()
        {
            ClickElement(Locators.Schedule.RightArrowShedulesButton);

            return this;
        }

        public SchedulePage ClickPrevDateButton()
        {
            ClickElement(Locators.Schedule.LeftArrowShedulesButton);

            return this;
        }

        public SchedulePage ClickTodayDateButton()
        {
            ClickElement(Locators.Schedule.TodayButton);

            return this;
        }

        public SchedulePage ClickCalendarButton()
        {
            ClickElement(Locators.Schedule.CalendarMenu);

            return this;
        }

        public SchedulePage ClickNavbarMenuSheduleButton()
        {
            ClickElement(Locators.Schedule.ClickToNavbarMenuSheduleButton);

            return this;
        }

        public SchedulePage InputDateField()
        {
            ClickElement(Locators.Schedule.InputDateField);

            return this;
        }

        public SchedulePage ClickArrowRandomize(out DateTime date)
        {
            date = ScheduleHelper.ClickArrowRandomize();

            return this;
        }

        public SchedulePage VerifyDateStartAtMonday(DateTime date)
        {
            string expected = ScheduleHelper.ExpectedFirstDayOfWeek(date);
            string actual = ScheduleHelper.ActualFirstDayOfWeek();
            Assert.AreEqual(expected, actual);

            return this;
        }

        public SchedulePage VerifyDateEndAtSunday(DateTime date)
        {
            string expected = ScheduleHelper.ExpectedLastDayOfWeek(date);
            string actual = ScheduleHelper.ActualLastDayOfWeek();
            Assert.AreEqual(expected, actual);

            return this;
        }

        public SchedulePage VerifyDateFirstDayOfWeek(DateTime date)
        {
            string expected = ScheduleHelper.ExpectedFirstDayOfWeek(date);
            string actual = ScheduleHelper.ActualFirstDayOfWeekFromTable();
            Assert.AreEqual(expected, actual);

            return this;
        }

        public SchedulePage VerifyDateLastDayOfWeek(DateTime date)
        {
            string expected = ScheduleHelper.ExpectedLastDayOfWeek(date);
            string actual = ScheduleHelper.ActualLastDayOfWeekFromTable();
            Assert.AreEqual(expected, actual);

            return this;
        }

        public SchedulePage VerifyTodayDate()
        {
            string expected = Convert.ToDateTime(ScheduleHelper.GetAttributeValue(Locators.Schedule.CalendarMenu)).ToShortDateString();
            string actual = DateTime.Now.ToShortDateString();
            Assert.AreEqual(expected, actual);

            return this;
        }
    }
}

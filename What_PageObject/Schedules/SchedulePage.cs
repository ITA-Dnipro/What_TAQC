using What_PageObject;
using What_PageObject.Schedules;

namespace WHAT_PageObject.Schedules
{
    public class SchedulePage : BasePage
    {
        public SchedulePage ClickNextDateButton()
        {
            ClickElement(Locators.RightArrowShedulesButton);

            return this;
        }

        public SchedulePage ClickPrevDateButton()
        {
            ClickElement(Locators.LeftArrowShedulesButton);

            return this;
        }

        public SchedulePage ClickTodayDateButton()
        {
            ClickElement(Locators.TodayButton);

            return this;
        }

        public SchedulePage ClickCalendarButton()
        {
            ClickElement(Locators.CalendarMenu);

            return this;
        }

        public SchedulePage ClickNavbarMenuSheduleButton()
        {
            ClickElement(Locators.ClickToNavbarMenuSheduleButton);

            return this;
        }

        public SchedulePage InputDateField()
        {
            ClickElement(Locators.InputDateField);

            return this;
        }
    }
}

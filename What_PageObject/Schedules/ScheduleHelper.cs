using OpenQA.Selenium;
using What_Common.DriverManager;
using WHAT_PageObject.Schedules;

namespace What_PageObject.Schedules
{
    public static class ScheduleHelper
    {
        static SchedulePage schedule = new SchedulePage();

        public static DateTime ClickArrowRandomize()
        {
            int i = 0;
            int y = 2;

            var date = DateTime.Now;
            int number = Convert.ToInt32((uint)Guid.NewGuid().GetHashCode() % 200);

            Random rnd = new Random();

            while (true)
            {
                if (i < rnd.Next(number))
                {
                    if (rnd.Next(y) == i)
                    {
                        schedule.ClickPrevDateButton();
                        date = date.AddDays(-7);
                    }
                    else
                    {
                        schedule.ClickNextDateButton();
                        date = date.AddDays(7);
                    }
                }
                else
                {
                    return date;
                }
            }
        }

        public static string GetAttributeValue(By locator)
        {
            return Driver.Current.FindElement(locator).GetAttribute("value");
        }

        public static string GetTextValue(By locator)
        {
            return Driver.Current.FindElement(locator).Text;
        }

        public static string GetDateText(By locator)
        {
            return GetTextValue(locator);
        }

        public static string ActualFirstDayOfWeek()
        {
            return GetDateText(Locators.DateText).Split('-')[0].Trim();
        }

        public static string ActualLastDayOfWeek()
        {
            return GetDateText(Locators.DateText).Split('-')[1].Trim();
        }

        public static string ActualFirstDayOfWeekFromTable()
        {
            return GetDateText(Locators.StartTableDateCsspath);
        }

        public static string ActualLastDayOfWeekFromTable()
        {
            return GetDateText(Locators.EndTableDateCsspath);
        }

        public static string ExpectedFirstDayOfWeek(DateTime date)
        {
            return date.StartOfWeek(DayOfWeek.Monday).ToString("dd/MM");
        }

        public static string ExpectedLastDayOfWeek(DateTime date)
        {
            return date.StartOfWeek(DayOfWeek.Sunday).AddDays(7).ToString("dd/MM");
        }
    }

    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}

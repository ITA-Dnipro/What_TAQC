using NUnit.Framework;
using System;
using What_Common.DriverManager;
using What_PageObject;
using What_PageObject.SignInPage;

namespace What_UITest.ScheduleTests
{
    public class ClickTodayButtonTest : BaseTest
    {
        private SignInPageObject signInPage;
        private DateTime date;

        [SetUp]
        public void Setup()
        {
            signInPage = new SignInPageObject(Driver.Current);
            signInPage.LogIn("james.smith@example.com", "Nj_PJ7K9", "http://localhost:8080/");
        }

        [Test]
        //[Repeat(5)]
        public void TodayButtonTest()
        {
            Pages.Schedule.ClickNavbarMenuSheduleButton()
                 .ClickArrowRandomize(out date)
                 .VerifyDateStartAtMonday(date)
                 .VerifyDateEndAtSunday(date)
                 .VerifyDateFirstDayOfWeek(date)
                 .VerifyDateLastDayOfWeek(date)
                 .ClickTodayDateButton()
                 .VerifyDateStartAtMonday(DateTime.Now)
                 .VerifyDateEndAtSunday(DateTime.Now)
                 .VerifyDateFirstDayOfWeek(DateTime.Now)
                 .VerifyDateLastDayOfWeek(DateTime.Now)
                 .VerifyTodayDate();
        }
    }
}
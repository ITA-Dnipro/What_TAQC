using NUnit.Framework;
using System;
using What_Common.DriverManager;
using What_PageObject;
using What_PageObject.SchedulesPage;
using What_PageObject.SignInPage;

namespace What_UITest.ScheduleTests
{
    public class ClickArrowSheduleTest : BaseTest
    {
        private SignInPageObject signInPage;
        DateTime date;

        [SetUp]
        public void Setup()
        {
            signInPage = new SignInPageObject(Driver.Current);
            signInPage.LogIn("john.williams@example.com", "9mw6AJB_", "http://localhost:8080/");
        }

        [Test]
        //[Repeat(5)]
        public void ArrowSheduleTest()
        {
            Pages.Schedule.ClickNavbarMenuSheduleButton()
                .ClickArrowRandomize(out date)
                .VerifyDateStartAtMonday(date)
                .VerifyDateEndAtSunday(date)
                .VerifyDateFirstDayOfWeek(date)
                .VerifyDateLastDayOfWeek(date);
        }
    }
}
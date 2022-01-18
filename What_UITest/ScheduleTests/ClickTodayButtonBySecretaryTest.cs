using NUnit.Framework;
using System;
using What_Common.DataProvider;
using What_PageObject.SchedulesPage;
using What_PageObject.SignInPage;

namespace What_UITest.ScheduleTests
{
    public class ClickTodayButtonBySecretaryTest : BaseTest
    {
        private SignInPage signInPage;
        private SchedulePage schedule;
        private LoginDetails user;

        private DateTime date;

        [SetUp]
        public void Setup()
        {
            signInPage = new SignInPage();
            schedule = new SchedulePage();
            user = Controller.GetUser(Controller.UserRole.Secretary);
            signInPage.LogIn(user.Email, user.Password);
        }

        [Test(Description = "DP220TAQC-194")]
        public void TodayButtonTest()
        {
            schedule.ClickNavbarMenuSheduleButton()
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
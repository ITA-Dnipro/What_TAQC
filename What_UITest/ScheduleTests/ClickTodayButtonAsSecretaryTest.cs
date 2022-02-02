using NUnit.Framework;
using System;
using What_Common.DataProvider;
using What_PageObject.SchedulesPage;
using What_PageObject.SignInPage;

namespace What_UITest.ScheduleTests
{
    public class ClickTodayButtonAsSecretaryTest : BaseTest
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
            schedule.SidebarNavigateTo<SchedulePage>()
                    .ClickArrowRandomize(out date)
                    .VerifyDateStartAtMondayFromTable(date)
                    .VerifyDateEndAtSundayFromTable(date)
                    .VerifyDateFirstDayOfWeek(date)
                    .VerifyDateLastDayOfWeek(date)
                    .ClickTodayDateButton()
                    .VerifyDateStartAtMondayFromTable(DateTime.Now)
                    .VerifyDateEndAtSundayFromTable(DateTime.Now)
                    .VerifyDateFirstDayOfWeek(DateTime.Now)
                    .VerifyDateLastDayOfWeek(DateTime.Now)
                    .VerifyTodayDate();
        }
    }
}
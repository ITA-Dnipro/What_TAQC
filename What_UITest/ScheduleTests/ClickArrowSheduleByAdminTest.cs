using NUnit.Framework;
using System;
using What_Common.DataProvider;
using What_PageObject.SchedulesPage;
using What_PageObject.SignInPage;

namespace What_UITest.ScheduleTests
{
    public class ClickArrowSheduleByAdminTest : BaseTest
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
            user = Controller.GetUser(Controller.UserRole.Admin);
        }

        [Test(Description = "DP220TAQC-193")]
        public void ArrowSheduleTest()
        {
            signInPage.LogIn(user.Email, user.Password);

            schedule.ClickNavbarMenuSheduleButton()
                    .ClickArrowRandomize(out date)
                    .VerifyDateStartAtMonday(date)
                    .VerifyDateEndAtSunday(date)
                    .VerifyDateFirstDayOfWeek(date)
                    .VerifyDateLastDayOfWeek(date);
        }
    }
}
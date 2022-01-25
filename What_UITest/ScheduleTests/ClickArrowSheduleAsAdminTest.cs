using NUnit.Framework;
using System;
using What_Common.DataProvider;
using What_PageObject.SchedulesPage;
using What_PageObject.SignInPage;

namespace What_UITest.ScheduleTests
{
    public class ClickArrowSheduleAsAdminTest : BaseTest
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
            signInPage.LogIn(user.Email, user.Password);

        }

        [Test(Description = "DP220TAQC-193")]
        public void ArrowSheduleTest()
        {
            schedule.SidebarNavigateTo<SchedulePage>()
                    .ClickArrowRandomize(out date)
                    .VerifyDateStartAtMondayFromTable(date)
                    .VerifyDateEndAtSundayFromTable(date)
                    .VerifyDateFirstDayOfWeek(date)
                    .VerifyDateLastDayOfWeek(date);
        }
    }
}
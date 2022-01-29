using NUnit.Framework;
using System;
using System.Collections.Generic;
using What_APITest.API_Object.Shedule;
using What_APITest.Entities.Accounts;
using What_APITest.Entities.Shedule;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.Shedule
{
    public class PostShedule : API_BaseTest
    {
        private LoginDetails user;
        private GetAllShedule shedule;
        Shedules newShedule;
        Shedules.Event sheduleEvent;

        [SetUp]
        public void Setup()
        {
            user = Controller.GetUser(Controller.UserRole.Admin);
            var role = Controller.UserRole.Admin.ToString().ToLower();

            shedule = new GetAllShedule(new User { Email = user.Email, Password = user.Password, Role = role });

            sheduleEvent = new Shedules.Event
            {
                StudentGroupId = 1,
                ThemeId = 1,
                MentorId = 1,
                EventStart = DateTime.Now.AddYears(-1),
                EventFinish = DateTime.Now
            };

            newShedule = new Shedules
            {
                StudentGroupId = 1,
                EventStart = DateTime.Now.AddYears(-1),
                EventFinish = DateTime.Now,
                Events = new List<Shedules.Event>() { sheduleEvent }
            };
        }

        [Test]
        public void PostSheduleTest()
        {
            shedule.CreateNewShedule(newShedule);
        }
    }
}

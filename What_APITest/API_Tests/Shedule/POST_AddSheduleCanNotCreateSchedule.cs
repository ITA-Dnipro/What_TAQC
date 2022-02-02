﻿using NUnit.Framework;
using What_APIObject.API_Object.Shedule;
using What_APIObject.Entities.Accounts;
using What_Common.DataProvider;


namespace What_APITest.API_Tests.Shedule
{
    public class POST_AddSheduleCanNotCreateSchedule : BaseTest
    {
        private LoginDetails user;
        private GetAllShedule shedule;

        [SetUp]
        public void Setup()
        {
            user = Controller.GetUser(Controller.UserRole.Admin);
            var role = Controller.UserRole.Admin.ToString().ToLower();

            shedule = new GetAllShedule(new User { Email = user.Email, Password = user.Password, Role = role });
        }

        [Test]
        public void PostSheduleTest()
        {
            shedule.GenerateWrongDataForShedule()
                   .VerifyShedulesBadRequest();
        }
    }
}
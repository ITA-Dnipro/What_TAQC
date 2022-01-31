using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using What_APIObject.Entities.Accounts;
using What_APIObject.Objects.Accounts;
using What_Common.DataProvider;

namespace What_APITest.API_Tests.Acounts
{

    internal class ChangePasswordTest
    {
        LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
        ChangePasswordObject changePasswordPage;
        RegisterUser user;
        RegisterUser user2;
        


        [SetUp]
        public void Setup()
        {

            changePasswordPage = new ChangePasswordObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });

        }
        [Test]
        public void ChangingPasswordTest()
            {
            changePasswordPage
                .RegistrationNewUser(out user)
                .CreateNewSecretary();
            changePasswordPage = new ChangePasswordObject(new User { Email = user.Email, Password = user.Password, Role = Controller.UserRole.Secretary.ToString().ToLower() });
            //changePasswordPage.Login();
            changePasswordPage.GenerateNewPassword(user);
                changePasswordPage.ChangePassword(out user2);
            changePasswordPage = new ChangePasswordObject(new User { Email = user2.Email, Password = user2.Password, Role = Controller.UserRole.Secretary.ToString().ToLower() });

        }
    }
}

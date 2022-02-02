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

    internal class PUT_ChangePassword_Successful
    {
        LoginDetails admin = Controller.GetUser(Controller.UserRole.Admin);
        ChangePasswordObject changePasswordObject;
        RegisterUser user;
        RegisterUser user2;
        


        [SetUp]
        public void Setup()
        {

            changePasswordObject = new ChangePasswordObject(new User { Email = admin.Email, Password = admin.Password, Role = Controller.UserRole.Admin.ToString().ToLower() });

        }
        [Test]
        public void ChangingPasswordTest()
            {
            changePasswordObject 
            .RegistrationNewUser(out user)
            .CreateNewSecretary();
            changePasswordObject = new ChangePasswordObject(new User { Email = user.Email, Password = user.Password, Role = Controller.UserRole.Secretary.ToString().ToLower() })
            .GenerateNewPassword(user)
            .ChangePassword(out user2);
            changePasswordObject = new ChangePasswordObject(new User { Email = user2.Email, Password = user2.Password, Role = Controller.UserRole.Secretary.ToString().ToLower() })
            .VerifyNewPasswordValid(user,user2);

        }
    }
}

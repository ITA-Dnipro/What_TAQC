using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using What_APIObject.Entities.Accounts;
using What_APITest.Objects.Secretaries;
using What_Common.Utils;

namespace What_APIObject.Objects.Accounts
{
    public class ChangePasswordObject
    {
        private WHATClient client;
        private Uri uri;
        RegisterUser user;
        RegisterUser user2;
        private HttpStatusCode statusCode;
        private AccountUser accountUser;
        private ResetPassword resetPassword;
        private string password;

        public ChangePasswordObject(User user)
        {
            client = new WHATClient(user);
        }


        public RegisterUser CreateUser()
        {
            user = new RegisterUser();
            user.FirstName = StringGenerator.GenerateString(new Random().Next(2, 30));
            user.LastName = StringGenerator.GenerateString(new Random().Next(2, 30));
            user.Email = StringGenerator.GenerateEmail();
            user.Password = StringGenerator.GeneratePassword(new Random().Next(8, 16));
            user.ConfirmPassword = user.Password;
            return user;
        }

        public ChangePasswordObject RegistrationNewUser(out RegisterUser registerUser)
        {
            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, CreateUser(), out statusCode);
            accountUser = response;
            registerUser = user;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

        public ChangePasswordObject CreateNewSecretary()
        {
            uri = new Uri($"/api/v2/secretaries/{accountUser.Id}", UriKind.Relative);
            var response = client.Post<AccountUser>(uri, out statusCode);
            accountUser = response;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }

       
        public ChangePasswordObject GenerateNewPassword(RegisterUser user)
        {
            password = StringGenerator.GeneratePassword(10);
            resetPassword = new ResetPassword {CurrentPassword = user.Password, NewPassword = password, ConfirmNewPassword = password };
            this.user = user;
            //user2 = user;
            return this;
        }
        public ChangePasswordObject ChangePassword(out RegisterUser registerUser)
        {

            uri = new Uri($"/api/v2/accounts/password", UriKind.Relative);
            var response = client.Put<ResetPassword ,AccountUser>(uri,resetPassword,out statusCode);
            //accountUser = response;
           // user2.Password = resetPassword.NewPassword;
            registerUser = user ;
            //user2.Password = resetPassword.NewPassword;
            //registerUser.Password = resetPassword.NewPassword;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
            return this;
        }
        public ChangePasswordObject VerifyNewPasswordValid()
        {
            return this;
        }



    }
}

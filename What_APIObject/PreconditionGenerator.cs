using System.Net;
using What_APIObject;
using What_APIObject.Entities.Accounts;
using What_Common.Utils;

namespace What_APIObject
{
    public class PreconditionGenerator
    {
        WHATClient client;
        Uri uri;
        HttpStatusCode statusCode;

        public PreconditionGenerator()
        {
            client = new WHATClient(new User { Email = "james.smith@example.com", Password = "Nj_PJ7K9", Role = "admin" });
        }

        public AccountUser RegisterNewUser()
        {
            string password = StringGenerator.GeneratePassword(10);
            RegisterUser newUser = new RegisterUser
            {
                FirstName = StringGenerator.GenerateString(7),
                LastName = StringGenerator.GenerateString(7),
                Email = StringGenerator.GenerateEmail(),
                Password = password,
                ConfirmPassword = password
            };

            uri = new Uri($"/api/v2/accounts/reg", UriKind.Relative);
            var response = client.Post<RegisterUser, AccountUser>(uri, newUser, out statusCode);

            return response;
        }

        public T AssignNewUserToRole<T>(int accountId, UserRole Role)
            where T : class
        {
            switch (Role)
            {
                case UserRole.Secretary:
                    uri = new Uri($"/api/v2/secretaries/{accountId}", UriKind.Relative);
                    break;
                case UserRole.Mentor:
                    uri = new Uri($"/api/v2/mentors/{accountId}", UriKind.Relative);
                    break;
                case UserRole.Student:
                    uri = new Uri($"/api/v2/students/{accountId}", UriKind.Relative);
                    break;
                default:
                    break;
            }
            var response = client.Post<T>(uri, out statusCode);

            return response;
        }

        public string DisableUser(int accountId, UserRole Role)
        {
            switch (Role)
            {
                case UserRole.Secretary:
                    uri = new Uri($"/api/v2/secretaries/{accountId}", UriKind.Relative);
                    break;
                case UserRole.Mentor:
                    uri = new Uri($"/api/v2/mentors/{accountId}", UriKind.Relative);
                    break;
                case UserRole.Student:
                    uri = new Uri($"/api/v2/students/{accountId}", UriKind.Relative);
                    break;
                default:
                    break;
            }
            var response = client.Delete<String>(uri, out statusCode);

            return response;
        }
    }

    public enum UserRole
    {
        Secretary = 8,
        Mentor = 2,
        Student = 1
    }
}

using Newtonsoft.Json;

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Reflection;

namespace What_Common.DataProvider
{
    public class Controller
    {
        public enum UserRole
        {
            Admin,
            Secretary,
            Mentor,
            Student
        }

        private static LoginDetails[] DeserializeObject()
        {
            LoginDetails[] users = JsonConvert.DeserializeObject<LoginDetails[]>(File.ReadAllText(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName + "/What_Common/Resources/user.json"));
            return users;
        }
        private static string DecoddingString(string data)
        {
            string decodding = null;
            for (int i = 0; i < data.Length; i++)
            {
                decodding += (char)(data[i] - 5);
            }
            return decodding;
        }
        private static LoginDetails[] DecoddingObject(LoginDetails[] users)
        {
            foreach (var user in users)
            {
                user.Email = DecoddingString(user.Email);
                user.Password = DecoddingString(user.Password);
                user.Role = DecoddingString(user.Role);
            }
            return users;
        }
        public static LoginDetails GetUser(UserRole userRole)
        {
            LoginDetails[] users = DecoddingObject(DeserializeObject());
            foreach (var user in users)
            {
                if (user.Role == "1" && userRole == UserRole.Student)
                {
                    return user;
                }
                if (user.Role == "2" && userRole == UserRole.Mentor)
                {
                    return user;
                }
                if (user.Role == "4" && userRole == UserRole.Admin)
                {
                    return user;
                }
                if (user.Role == "8" && userRole == UserRole.Secretary)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
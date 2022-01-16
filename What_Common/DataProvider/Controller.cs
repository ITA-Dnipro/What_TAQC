using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace What_Common.DataProvider
{
    public class Controller
    {
        private static LoginDetails[] DeserializeObject()
        {
            LoginDetails[] users = JsonConvert.DeserializeObject<LoginDetails[]>(File.ReadAllText("user.json")); // What_TAQC/What_Common/Resources/user.json
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
        public static LoginDetails GetUser(string role)
        {
            LoginDetails[] users = DecoddingObject(DeserializeObject());
            foreach (var user in users)
            {
                if (user.Role == "1" && role == "student")
                {
                    return user;
                }
                if (user.Role == "2" && role == "mentor")
                {
                    return user;
                }
                if (user.Role == "4" && role == "admin")
                {
                    return user;
                }
                if (user.Role == "8" && role == "secretary")
                {
                    return user;
                }
            }
            return null;
        }
    }
}

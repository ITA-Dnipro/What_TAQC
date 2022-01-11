using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace What_PageObject.DataProvider
{
    public class Controller
    {
        public static LoginDetails[] DeserializeObject()
        {
            LoginDetails[] users = JsonConvert.DeserializeObject<LoginDetails[]>(File.ReadAllText("user.json")); // What_TAQC/What_Common/Resources/user.json
            return users;
        }
        public static string DecoddingString(string data)
        {
            string decodding = null;
            for (int i = 0; i < data.Length; i++)
            {
                decodding += (char)(data[i] - 5);
            }
            return decodding;
        }
        public static LoginDetails[] DecoddingObject(LoginDetails[] users)
        {
            foreach (var user in users)
            {
                user.Email = DecoddingString(user.Email);
                user.Password = DecoddingString(user.Password);
                user.Role = DecoddingString(user.Role);
            }
            return users;
        }
    }
}

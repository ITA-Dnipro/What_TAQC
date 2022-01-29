using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace What_APITest.Entities
{
    public class TokenResponse
    {
        [JsonPropertyName("fisrtName")]
        public string UserFirstName { get; set; }
        [JsonPropertyName("lastName")]
        public string UserLastName { get; set; }
        [JsonPropertyName("role")]
        public int UserRole { get; set; }
        [JsonPropertyName("roleList")]
        public Dictionary<string, string> RoleAndToken { get; set; }

    }

}

using System.Text.Json.Serialization;

namespace What_APITest.Entities
{
    public class Authentication
    {
        [JsonPropertyName("email")]
        public string UserEmail { get; set; }

        [JsonPropertyName("password")]
        public string UserPassword { get; set; }
    }

}

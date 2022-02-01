using Newtonsoft.Json;

namespace What_APITest.Entities.Accounts
{
    public class AccontsGrant
    {
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("role")]
        public int Role { get; set; }
    }
}

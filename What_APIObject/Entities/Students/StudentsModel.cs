using System.Text.Json.Serialization;


namespace What_APIObject.Entities.Students
{
    public class StudentsModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("avatarUrl")]
        public string AvatarUrl { get; set; }
    }
}

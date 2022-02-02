using Newtonsoft.Json;

namespace What_APIObject.Entities.Courses
{
    public class CoursesModel
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool IsActive { get; set; }

    }
}

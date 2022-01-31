using Newtonsoft.Json;

namespace What_APIObject.Entities.Courses
{
    public class CoursesPostModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}

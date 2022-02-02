using Newtonsoft.Json;

namespace What_APIObject.Entities.Courses
{
    public class CoursesPutModel
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}

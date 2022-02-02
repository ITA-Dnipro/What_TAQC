using Newtonsoft.Json;

namespace What_APIObject.Entities.Courses
{
    public class CoursesGetModel
    {
        [JsonProperty(PropertyName = "isActive")]
        public bool? IsActive { get; set; }
    }
}

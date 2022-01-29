using Newtonsoft.Json;
using System;

namespace What_APITest.Entities.Shedule
{
    public class ShedulesEvent
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("eventOccuranceId")]
        public int EventOccuranceId { get; set; }
        [JsonProperty("studentGroupId")]
        public int StudentGroupId { get; set; }
        [JsonProperty("themeId")]
        public int ThemeId { get; set; }
        [JsonProperty("mentorId")]
        public int MentorId { get; set; }
        [JsonProperty("lessonId")]
        public int LessonId { get; set; }
        [JsonProperty("eventStart")]
        public DateTime EventStart { get; set; }
        [JsonProperty("eventFinish")]
        public DateTime EventFinish { get; set; }
    }
}

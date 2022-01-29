using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace What_APITest.Entities.Shedule
{
    public class ShedulesByIdUpdateSingle
    {
        public class Root
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("studentGroupId")]
            public int StudentGroupId { get; set; }
            [JsonProperty("eventStart")]
            public DateTime EventStart { get; set; }
            [JsonProperty("eventFinish")]
            public DateTime EventFinish { get; set; }
            [JsonProperty("pattern")]
            public int Pattern { get; set; }
            [JsonProperty("events")]
            public List<Event>? Events { get; set; }
            [JsonProperty("storage")]
            public long Storage { get; set; }
        }

        public class Event
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
}

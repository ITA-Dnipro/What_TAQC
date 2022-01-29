using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace What_APITest.Entities.Shedule
{
    public class ShedulesById
    {
        public class Root
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("studentGroupId")]
            public int StudentGroupId { get; set; }
            [JsonPropertyName("eventStart")]
            public DateTime EventStart { get; set; }
            [JsonPropertyName("eventFinish")]
            public DateTime EventFinish { get; set; }
            [JsonPropertyName("pattern")]
            public int Pattern { get; set; }
            [JsonPropertyName("events")]
            public List<Event>? Events { get; set; }
            [JsonPropertyName("storage")]
            public long Storage { get; set; }
        }

        public class Event
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("eventOccuranceId")]
            public int EventOccuranceId { get; set; }
            [JsonPropertyName("studentGroupId")]
            public int StudentGroupId { get; set; }
            [JsonPropertyName("themeId")]
            public int ThemeId { get; set; }
            [JsonPropertyName("mentorId")]
            public int MentorId { get; set; }
            [JsonPropertyName("lessonId")]
            public int LessonId { get; set; }
            [JsonPropertyName("eventStart")]
            public DateTime EventStart { get; set; }
            [JsonPropertyName("eventFinish")]
            public DateTime EventFinish { get; set; }
        }
    }
}

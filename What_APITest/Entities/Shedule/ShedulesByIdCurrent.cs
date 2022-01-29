using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace What_APITest.Entities.Shedule
{
    public class ShedulesByIdCurrent
    {
        public class Root
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("pattern")]
            public int Pattern { get; set; }
            [JsonProperty("range")]
            public Range? Range { get; set; }
            [JsonProperty("context")]
            public Context? Context { get; set; }
        }

        public class Pattern
        {
            [JsonProperty("type")]
            public int Type { get; set; }
            [JsonProperty("interval")]
            public int Interval { get; set; }
            [JsonProperty("daysOfWeek")]
            public List<int>? DaysOfWeek { get; set; }
            [JsonProperty("index")]
            public int Index { get; set; }
            [JsonProperty("dates")]
            public object? Dates { get; set; }
        }

        public class Range
        {
            [JsonProperty("startDate")]
            public DateTime StartDate { get; set; }
            [JsonProperty("finishDate")]
            public DateTime FinishDate { get; set; }
        }

        public class Context
        {
            [JsonProperty("groupID")]
            public int GroupID { get; set; }
            [JsonProperty("themeID")]
            public object? ThemeID { get; set; }
            [JsonProperty("mentorID")]
            public object? MentorID { get; set; }
        }
    }
}

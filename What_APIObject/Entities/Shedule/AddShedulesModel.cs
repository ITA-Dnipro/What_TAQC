using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace What_APIObject.Entities.Shedule
{
    public class AddShedulesModel
    {
        public class Root
        {
            [JsonPropertyName("pattern")]
            public Pattern Pattern { get; set; }

            [JsonPropertyName("range")]
            public Range Range { get; set; }

            [JsonPropertyName("context")]
            public Context Context { get; set; }
        }

        public class Pattern
        {
            [JsonPropertyName("type")]
            public int Type { get; set; }

            [JsonPropertyName("interval")]
            public int Interval { get; set; }

            [JsonPropertyName("daysOfWeek")]
            public List<int> DaysOfWeek { get; set; }

            [JsonPropertyName("index")]
            public int Index { get; set; }

            [JsonPropertyName("dates")]
            public List<int> Dates { get; set; }
        }

        public class Range
        {
            [JsonPropertyName("startDate")]
            public DateTime StartDate { get; set; }

            [JsonPropertyName("finishDate")]
            public DateTime FinishDate { get; set; }
        }

        public class Context
        {
            [JsonPropertyName("groupID")]
            public int GroupID { get; set; }

            [JsonPropertyName("themeID")]
            public int ThemeID { get; set; }

            [JsonPropertyName("mentorID")]
            public int MentorID { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace What_APITest.Entities.Groups
{
    internal class GroupsGetLessonsById
    {
        public class GetLessonsById
        {
            [JsonPropertyName("themeName")]
            public string ThemeName { get; set; }

            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("presence")]
            public bool Presence { get; set; }

            [JsonPropertyName("mark")]
            public int Mark { get; set; }

            [JsonPropertyName("comment")]
            public string Comment { get; set; }

            [JsonPropertyName("studentGroupId")]
            public int StudentGroupId { get; set; }

            [JsonPropertyName("lessonDate")]
            public DateTime LessonDate { get; set; }
        }

    }
}

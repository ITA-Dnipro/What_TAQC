using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace What_APITest.Entities.Groups
{
    internal class GetHomeworksById
    {
        public class GetHomeworkById
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("dueDate")]
            public DateTime DueDate { get; set; }

            [JsonPropertyName("taskText")]
            public string TaskText { get; set; }

            [JsonPropertyName("lessonId")]
            public int LessonId { get; set; }

            [JsonPropertyName("publishingDate")]
            public DateTime PublishingDate { get; set; }

            [JsonPropertyName("createdBy")]
            public int CreatedBy { get; set; }

            [JsonPropertyName("attachmentIds")]
            public List<int> AttachmentIds { get; set; }

            [JsonPropertyName("themeName")]
            public object ThemeName { get; set; }
        }


    }
}

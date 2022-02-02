﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace What_APITest.Entities.Groups
{
    internal class GetStudentsGroupsById
    {
        public class GetGroupsById
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("courseId")]
            public int CourseId { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("startDate")]
            public DateTime StartDate { get; set; }

            [JsonPropertyName("finishDate")]
            public DateTime FinishDate { get; set; }

            [JsonPropertyName("studentIds")]
            public List<int> StudentIds { get; set; }

            [JsonPropertyName("mentorIds")]
            public List<int> MentorIds { get; set; }
        }

    }
}

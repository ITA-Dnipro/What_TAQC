﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models
{
    public class Course
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}

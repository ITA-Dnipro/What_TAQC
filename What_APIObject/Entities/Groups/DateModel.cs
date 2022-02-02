using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace What_APITest.Entities.Groups
{
    public class DateModel
    {
              
          

            [JsonPropertyName("startDate")]
            public DateTime StartDate { get; set; }

            [JsonPropertyName("finishDate")]
            public DateTime FinishDate { get; set; }

            


    }
}

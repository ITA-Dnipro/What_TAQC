using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace What_APITest.Entities.Groups
{
    internal class PostStudentGroupsMerge
    {
        public class StudentsGroupsMerge
        {
            [JsonPropertyName("resultingStudentGroupId")]
            public int ResultingStudentGroupId { get; set; }

            [JsonPropertyName("idsOfStudentGroupsToMerge")]
            public List<int> IdsOfStudentGroupsToMerge { get; set; }
        }
    }
}

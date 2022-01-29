using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_APITest.Entities.Mentors
{
    public class Mentor
    {
        [JsonProperty ("id")]
        public int Id { get; set; }  

        [JsonProperty ("email")]
        public string Email { get; set; }   

        [JsonProperty ("firstName")]
        public string Password { get; set; }    

        [JsonProperty ("lastName")]
        
        public string LastName { get; set; }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace What_APIObject.Entities.ForgotPassword
{
    public class ForgotPasswordModel
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("formUrl")]
        public string FormUrl { get; set; }
    }
}

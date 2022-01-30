﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace What_APIObject.Entities.Accounts
{
    public class AccountRoleGrantDto
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("role")]
        public int Role { get; set; }
    }
}

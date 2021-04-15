using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace xmedical_ehr.Account {
    public class Role : IdentityRole {
        public string DisplayName { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace xmedicalehr.api.Account
{
    public class Role : IdentityRole
    {
        public string DisplayName { get; set; }
    }
}

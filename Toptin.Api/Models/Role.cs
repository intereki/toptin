using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Toptin.Api.Models
{
    public class Role : IdentityRole
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
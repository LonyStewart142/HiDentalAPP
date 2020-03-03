using DatabaseLayer.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataBaseLayer.Models.Auth
{
    public class UserPermission : IdentityUserRole<string>
    {
        public  Permission Role { get; set; }
        public User User { get; set; }
    }
}

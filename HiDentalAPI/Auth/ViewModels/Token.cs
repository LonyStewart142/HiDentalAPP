using DatabaseLayer.Models;
using DataBaseLayer.Models.Auth;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Auth.Models
{
    public class AuthResult
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public bool Expire { get; set; }
        public List<Permission> Permissions { get; set; }
        public string UserName { get; set; }
    }
}

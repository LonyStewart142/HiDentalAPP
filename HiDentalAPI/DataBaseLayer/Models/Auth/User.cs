using DatabaseLayer.Enums;
using DataBaseLayer.Models.Auth;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DatabaseLayer.Models
{
    public class User : IdentityUser
    {
        public string Names { get; set; }
        public string LastNames { get; set; }
        public int Gender { get; set; }
        public string Password { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
        public State State { get; set; } = State.Active;
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual ICollection<Consultation> Consults { get; set; }
        public ICollection<UserPermission> UserRoles { get; set; }
    }
}

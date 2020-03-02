using System;
using System.Collections.Generic;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class User: CommonsProperty
    {
       
        public string Names { get; set; }
        public string LastNames { get; set; }
        public int Sex { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
        public virtual ICollection<Appointment> Citas { get; set; }
        public virtual ICollection<Consultation> Consultas { get; set; }
    }
}

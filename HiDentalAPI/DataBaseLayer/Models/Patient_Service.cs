using System;
using System.Collections.Generic;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class Patient_Service : CommonsProperty
    {
    

        public Guid ServiceID { get; set; }
        public Service Service { get; set; }

        public Guid UserID { get; set; }
        public User User { get; set; }

        public Guid PacienteID { get; set; }
        public Patient Paciente { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}

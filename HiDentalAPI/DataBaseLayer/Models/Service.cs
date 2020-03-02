using System;
using System.Collections.Generic;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class Service : CommonsProperty
    {
 
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }

    }
}

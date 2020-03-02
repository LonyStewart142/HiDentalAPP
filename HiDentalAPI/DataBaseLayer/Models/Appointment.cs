using System;
using BussinesLayer.Contracts;
using DatabaseLayer.Models;

namespace DatabaseLayer.Models
{
    public class Appointment : CommonsProperty
    {
        public string Objective { get; set; }
        public string Note { get; set; }

        public Guid PatientID { get; set; }
        public Patient Patient { get; set; }

        public Guid UserID { get; set; }
        public User User { get; set; }

    }
}

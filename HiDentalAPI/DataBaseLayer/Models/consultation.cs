﻿using System;
using BussinesLayer.Contracts;
using DatabaseLayer.Models;

namespace DatabaseLayer.Models
{
    public class Consultation : CommonsProperty
    {
      
        public string Condition { get; set; }

        public string Note { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}

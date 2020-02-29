using System;
using BussinesLogic.Contracts;
using DataLayer.Models;

namespace DataLayer.Models
{
    public class Consulta: CommonsProperty
    {
      
        public string Condicion { get; set; }
        public string Nota { get; set; }

        public Guid PacienteID { get; set; }
        public Patient Paciente { get; set; }

        public Guid UserID { get; set; }
        public User User { get; set; }
    }
}

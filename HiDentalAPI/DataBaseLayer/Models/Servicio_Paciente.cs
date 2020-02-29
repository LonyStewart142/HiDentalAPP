using System;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class Servicio_Paciente : CommonsProperty
    {
    

        public Guid ServicioID { get; set; }
        public Servicio Servicio { get; set; }

        public Guid PacienteID { get; set; }
        public Patient Paciente { get; set; }

        public Guid UserID { get; set; }
        public User User { get; set; }
    }
}

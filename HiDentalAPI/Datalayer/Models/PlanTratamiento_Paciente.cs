using System;
using BussinesLogic.Contracts;

namespace DataLayer.Models
{
    public class PlanTratamiento_Paciente : CommonsProperty
    {

        public Guid PlanTratamientoID { get; set; }
        public Plan_Tratamiento Plan_Tratamiento { get; set; }

        public Guid ConsultaID { get; set; }
        public Consulta Consulta { get; set; }

        public Guid PacienteID { get; set; }
        public Patient Paciente { get; set; }

        public Guid UserID { get; set; }
        public User User { get; set; }


    }
}

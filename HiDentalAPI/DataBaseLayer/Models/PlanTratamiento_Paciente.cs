using System;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class PlanTratamiento_Paciente : CommonsProperty
    {

        public Guid PlanTratamientoID { get; set; }
        public Treatment_plan Treatment_plan { get; set; }

        public Guid ConsultationID { get; set; }
        public Consultation Consultation { get; set; }

        public Guid PatientID { get; set; }
        public Patient Patient { get; set; }

        public Guid UserID { get; set; }
        public User User { get; set; }


    }
}

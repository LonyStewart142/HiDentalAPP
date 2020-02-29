using System;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class AbonoPlan_Pago: CommonsProperty
    {
       
        public double Abono { get; set; }
        public bool Estado { get; set; } //Pagado o Pendiente

        public Guid PlanPagoID { get; set; }
        public Plan_Pago Plan_Pago { get; set; }


    }
}

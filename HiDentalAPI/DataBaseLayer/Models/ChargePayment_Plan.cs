using System;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class AbonoPlan_Pago: CommonsProperty
    {
       
        public double Charge { get; set; }
        public bool StateCharge { get; set; } //Pagado o Pendiente

        public Guid PaymentPlanID { get; set; }
       // public Payment_plan Payment_plan { get; set; }


    }
}

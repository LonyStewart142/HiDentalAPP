using System;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class ChargePayment_Plan : CommonsProperty
    {
       
        public double Charge { get; set; }
        public bool StateCharge { get; set; } //Pagado o Pendiente

        public Guid PaymentPlanID { get; set; }
        public Payment_plan Payment_plan { get; set; }


    }
}

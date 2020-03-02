using System;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class Treatment_plan : CommonsProperty
    {
 
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }


        public Guid  PaymentPlanID { get; set; }
        public Payment_plan Payment_plan { get; set; }
    }
}

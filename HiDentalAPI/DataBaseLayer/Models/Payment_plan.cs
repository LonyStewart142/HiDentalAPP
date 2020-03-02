using System;
using System.Collections.Generic;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class Payment_plan : CommonsProperty
    {
        

        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public virtual ICollection<ChargePayment_Plan> ChargesPayment_Plan { get; set; }

    }
}

using System;
using System.Collections.Generic;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class Plan_Pago: CommonsProperty
    {
        

        public DateTime Inicia { get; set; }
        public DateTime Finaliza { get; set; }

        public ICollection<AbonoPlan_Pago> Citas { get; set; }

    }
}

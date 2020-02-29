using System;
using System.Collections.Generic;
using BussinesLogic.Contracts;

namespace DataLayer.Models
{
    public class Plan_Pago: CommonsProperty
    {
        

        public DateTime Inicia { get; set; }
        public DateTime Finaliza { get; set; }

        public ICollection<AbonoPlan_Pago> Citas { get; set; }

    }
}

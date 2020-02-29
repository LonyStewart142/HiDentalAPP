﻿using System;
using BussinesLogic.Contracts;

namespace DataLayer.Models
{
    public class Plan_Tratamiento : CommonsProperty
    {
 
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
        public string Descripcion { get; set; }

        public Guid PlanPagoID { get; set; }
        public Plan_Pago Plan_Pago { get; set; }
    }
}

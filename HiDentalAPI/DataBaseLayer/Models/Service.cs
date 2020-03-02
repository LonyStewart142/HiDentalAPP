using System;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class Servicio : CommonsProperty
    {
 
        public string Nombre { get; set; }
        public string Costo { get; set; }
        public string Descripcion { get; set; }




    }
}

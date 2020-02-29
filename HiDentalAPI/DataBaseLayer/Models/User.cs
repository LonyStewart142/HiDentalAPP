using System;
using System.Collections.Generic;
using BussinesLayer.Contracts;

namespace DatabaseLayer.Models
{
    public class User: CommonsProperty
    {
       
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Sexo { get; set; }
        public string Correo { get; set; }
        public string Usuario { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
        public ICollection<Cita> Citas { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
    }
}

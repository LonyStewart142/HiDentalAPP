using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BussinesLayer.Contracts;
using DatabaseLayer.Models;

namespace DatabaseLayer.Models
{
    public class Patient : CommonsProperty
    {
        [Required(ErrorMessage = "EL CAMPO {0} ES REQUERIDO")]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public string Cedula { get; set; }
        [Required]
        public string Direccion { get; set; }
        public string Direccion_Ofic { get; set; }
        public string Foto { get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string Email { get; set; }
        public string Ocupaccion { get; set; }
        public string Referido_Por { get; set; }
        [Required]
        public string Telefono_celular { get; set; }
        public string Tel_Oficina { get; set; }
        [Required]
        public string Fecha_Nacimiento { get; set; }

        public virtual IEnumerable<Cita> Citas { get; set; }
        public virtual IEnumerable<Consulta> Consultas { get; set; }

    
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial.Models
{
    public class PersonaRequest
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CodigoPostal { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public int? TelContacto { get; set; }
    }
}
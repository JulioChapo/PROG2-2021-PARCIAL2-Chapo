using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Persona
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int CodigoPostal { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int? TelContacto { get; set; }
    }
}

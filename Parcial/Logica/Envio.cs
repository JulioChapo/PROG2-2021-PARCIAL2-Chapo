using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Envio
    {
        public string CodigoEnvio { get; set; }
        public Destinatario Destinatario { get; set; }
        public Repartidor Repartidor { get; set; }
        public estado Estado { get; set; }
        public enum estado
        {
            Pendiente,
            AsignadoRepartidor,
            EnCamino,
            Entregado
        }
        public DateTime FechaEstimada { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEntrega { get; set; }

        public string GenerarCodigo()
        {
            Random random = new Random();
            return CodigoEnvio = Convert.ToString(random.Next());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial.Models
{
    public class EnvioRequest
    {
        public string CodigoEnvio { get; set; }
        public string Destinatario { get; set; }
        public string Repartidor { get; set; }
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
    }
}
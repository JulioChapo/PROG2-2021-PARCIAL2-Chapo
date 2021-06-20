using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public sealed class Aplicacion
    {
        public static List<Envio> Envios { get; set; }
        public static List<Persona> Personas { get; set; }
        public static List<Destinatario> Destinatarios { get; set; }


        public static Destinatario BuscarPersona(int dni)
        {
            Destinatario persona = Destinatarios.Find(x => x.DNI == dni);
            if (persona != null && persona.TelContacto != null)
            {
                return persona;
            }
            return null;
        }

        public static Envio CargarNuevoEnvio(int dni, DateTime fechaEstimada, string descripcion)
        {
            Envio envio = new Envio();
            if (Envios == null)
                Envios = new List<Envio>();
            Persona persona = BuscarPersona(dni);
            envio.CodigoEnvio = envio.GenerarCodigo();
            envio.Destinatario = (Destinatario) persona;
            envio.Repartidor = null;
            envio.Estado = 0;
            envio.FechaEstimada = fechaEstimada;
            envio.Descripcion = descripcion;
            Envios.Add(envio);
            return envio;           
        }

        public static Envio ActualizarEnvio(string codigoSeguimiento, double monto)
        {
            Envio envio = Envios.Find(x => x.CodigoEnvio == codigoSeguimiento);
            envio.Estado += 1;
            if (envio.Estado == Envio.estado.Entregado)
            {
                envio.Repartidor.Comision = ObtenerComision(monto);
                envio.FechaEntrega = DateTime.Today;
                Envios.Add(envio);
                return envio;
            }
            return envio;
        }

        //PORQUE EL .15?
        public static double ObtenerComision( double MontoTotal)
        {
            return MontoTotal / (MontoTotal * 0.15);
        }

        //DEBIA SER UN METODO DE EXTENSION POR EJEMPLO PARA UNA CLSAE "COORDENADAS"
        public static double Asignacion(Envio envio)
        {
            Persona destinatario = Personas.Find(x => x.Nombre == envio.Destinatario.Nombre);

            double distance = 0;
            double Lat = (envio.Destinatario.Latitud - envio.Repartidor.Latitud) * (Math.PI / 180);
            double Lon = (envio.Destinatario.Longitud - envio.Repartidor.Longitud) * (Math.PI / 180);
            double a = Math.Sin(Lat / 2) * Math.Sin(Lat / 2) + Math.Cos(envio.Destinatario.Latitud * (Math.PI / 180)) * Math.Cos(envio.Repartidor.Latitud * (Math.PI / 180)) * Math.Sin(Lon / 2) * Math.Sin(Lon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            distance = 6.371 * c;
            return distance;
        }

        

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Logica;

namespace Parcial.Controllers
{
    //LA URL QUEDA MAL, NO SE RECIBE EL PARAMETRO EN TODOS LOS METODOS. SE DUPLICA "ENVIOS" EN LA RUTA DE LOS METODOS
    [RoutePrefix("Envios/{CodigoEnvio}")]
    public class EnvioController : ApiController
    {
        //NO ES NECESARIO
        [Route("Envios")]
        public IHttpActionResult Get()
        {
            return Ok(Aplicacion.Envios);
        }

        //NO ES NECESARIO
        [Route("Envios/{dni}")]
        public IHttpActionResult Get(int dni)
        {
            if (Aplicacion.BuscarPersona(dni) == null)
                return BadRequest();

            return Ok(Aplicacion.BuscarPersona(dni));
        }

        //DEBERIA RECIBIR LOS PARAMETROS EN EL BODY CON UNA CLASE REQUEST
        [Route("Envios")]
        public IHttpActionResult Post(int dni, DateTime FechaEstimada, [FromBody]string Descripcion)
        {
            if ((Aplicacion.CargarNuevoEnvio(dni, FechaEstimada, Descripcion) != null))
            {
                return Created("", Aplicacion.CargarNuevoEnvio(dni, FechaEstimada, Descripcion));
            }
            return BadRequest();
            
        }

        //INCOMPLETO
        [Route("Envios/{codigoSeguimiento}")]
        public IHttpActionResult Put(string codigoSeguimiento, [FromBody]double value)
        {
            return
        }


    }
}

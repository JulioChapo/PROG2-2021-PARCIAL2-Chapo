using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Logica;

namespace Parcial.Controllers
{
    [RoutePrefix("Envios/{CodigoEnvio}")]
    public class EnvioController : ApiController
    {
        [Route("Envios")]
        public IHttpActionResult Get()
        {
            return Ok(Aplicacion.Envios);
        }

        [Route("Envios/{dni}")]
        public IHttpActionResult Get(int dni)
        {
            if (Aplicacion.BuscarPersona(dni) == null)
                return BadRequest();

            return Ok(Aplicacion.BuscarPersona(dni));
        }

        [Route("Envios")]
        public IHttpActionResult Post(int dni, DateTime FechaEstimada, [FromBody]string Descripcion)
        {
            if ((Aplicacion.CargarNuevoEnvio(dni, FechaEstimada, Descripcion) != null))
            {
                return Created("", Aplicacion.CargarNuevoEnvio(dni, FechaEstimada, Descripcion));
            }
            return BadRequest();
            
        }

        [Route("Envios/{codigoSeguimiento}")]
        public IHttpActionResult Put(string codigoSeguimiento, [FromBody]double value)
        {
            return
        }


    }
}

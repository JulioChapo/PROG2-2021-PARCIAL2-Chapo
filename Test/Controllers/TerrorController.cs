using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Test.Controllers
{
    public class TerrorController : ApiController
    {
        // GET: api/Terror
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Terror/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Terror
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Terror/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Terror/5
        public void Delete(int id)
        {
        }
    }
}

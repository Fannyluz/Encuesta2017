using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Enuesta.Distribucion.API.Controllers
{
    public class PruebasController : ApiController
    {
        // GET: api/Pruebas
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pruebas/5
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST: api/Pruebas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pruebas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pruebas/5
        public void Delete(int id)
        {
        }
    }
}

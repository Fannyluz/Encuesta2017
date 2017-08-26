using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Enuesta.Distribucion.API.Controllers
{
    public class CruzController : ApiController
    {
        // GET: api/Cruz
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cruz/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cruz
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cruz/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cruz/5
        public void Delete(int id)
        {
        }
    }
}

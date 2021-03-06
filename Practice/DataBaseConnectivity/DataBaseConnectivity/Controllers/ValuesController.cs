using EmployeeDataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataBaseConnectivity.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<demo> Get()
        {
            using (masterEntities entities = new masterEntities())
            {

                return entities.demoes.ToList();
            }
        }
        public demo Get(int id)
        {
            using (masterEntities entities = new masterEntities())
            {
                return entities.demoes.FirstOrDefault(x => x.id == id);
            }
        }
    
        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

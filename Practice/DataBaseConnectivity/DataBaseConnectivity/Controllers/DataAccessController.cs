using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeDataAcces;
namespace DataBaseConnectivity.Controllers
{
    public class DataAccessController : Controller
    {
        [Route("api/Data")]
        [HttpGet]
        public IEnumerable<demo> Get()
        {
            using(masterEntities entities =new masterEntities())
            {
                return entities.demoes.ToList();
            }
        }
        public demo Get(int id)
        {
            using (masterEntities entities=new masterEntities())
            {
                return entities.demoes.FirstOrDefault(x => x.id == id);
            }
        }
        // GET: DataAccess
        public ActionResult Index()
        {
            return View();
        }
    }
}
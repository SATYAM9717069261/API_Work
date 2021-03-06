using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StudentAPI.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        //sql Connection 

        private SqlConnection _con;
        private SqlDataAdapter _adapter;
        

        public IEnumerable<Student> Get()
        {
            _con = new SqlConnection("datasource=SATYAM;Initial catalog=User1;");
            DataTable _dt = new DataTable();
            var query = "select * from demo";
            _adapter = new SqlDataAdapter { SelectCommand = new SqlCommand(query, _con) };
            _adapter.Fill(_dt);
            List<Student> students = new List<Models.Student>(_dt.Rows.Count);
            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow studentRecord in _dt.Rows)
                {
                    students.Add(new ReadStudent(studentRecord));
                }
            }
            return students;
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}

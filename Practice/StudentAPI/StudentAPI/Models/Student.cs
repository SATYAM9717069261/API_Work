using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace StudentAPI.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Phone_no { get; set; }
    }
    public class createStudent : Student
    {

    }
    public class ReadStudent : Student
    {
        public ReadStudent(DataRow row)
        {
            id = Convert.ToInt16(row["id"]);
            name = row["name"].ToString();
            Phone_no = row["Phone_no"].ToString();
        }
        public int id { get; set; }
        public string name { get; set; }
        public string Phone_no { get; set; }

    }
}
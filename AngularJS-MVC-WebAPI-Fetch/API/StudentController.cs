using AngularJS_MVC_WebAPI_Fetch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJS_MVC_WebAPI_Fetch.API
{
    public class StudentController : ApiController
    {
        SchoolMangementEntities _ctx = null; // SchoolMangementEntities is data model name
        public StudentController()
        {
            _ctx = new SchoolMangementEntities();
        }
        public List<tbl_Student> GetStudents()
        {
            List<tbl_Student> students = null;
            try
            {
                students = _ctx.tbl_Student.ToList();
            }
            catch 
            {

                students = null;
            }
            return students;
        }

    }
}

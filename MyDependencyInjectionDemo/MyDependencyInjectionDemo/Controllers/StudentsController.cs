using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyDependencyInjectionDemo.Businesslayer;
using MyDependencyInjectionDemo.Models;



namespace MyDependencyInjectionDemo.Controllers
{

    public class StudentsController : ApiController
    {
        private IStudentBusinesslayer _iobc;
        public StudentsController(IStudentBusinesslayer iobc)
        {
            _iobc = iobc;
        }
        [HttpGet]
        public Student Get()
        {
          //  return Student.GetSchoolInfo();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDependencyInjectionDemo.Models
{
    public class Student
    {
        public string id { get; set;}
        public string name { get; set; }
        public string address{ get; set; }
        public string phone{ get; set; }

        internal static Student GetSchoolInfo()
        {
            throw new NotImplementedException();
        }
    }
}
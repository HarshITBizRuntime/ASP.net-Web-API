using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyDependencyInjectionDemo.Models;

namespace MyDependencyInjectionDemo.DataAccesslayer
{
    public class SchoolDataAccesslayer : ISchoolDataAccesslayer
    {
        public Student GetStudent()
        {
            return new Student
            {
                id = "01",
                name = "harshad",
                address = "Blr",
                address = "34567890",

            };
        }
    }
}
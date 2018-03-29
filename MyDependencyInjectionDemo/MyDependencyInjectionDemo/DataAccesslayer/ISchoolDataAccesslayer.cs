using MyDependencyInjectionDemo.Businesslayer;
using MyDependencyInjectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDependencyInjectionDemo.DataAccesslayer
{
    public interface ISchoolDataAccesslayer
    {
        School GetSchoolInfo { get; }

        Student GetStudent();
    }
}
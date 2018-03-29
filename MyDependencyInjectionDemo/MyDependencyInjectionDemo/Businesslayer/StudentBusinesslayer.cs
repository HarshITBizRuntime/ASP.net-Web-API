using MyDependencyInjectionDemo.DataAccesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDependencyInjectionDemo.Businesslayer
{
    public class StudentBusinesslayer : IStudentBusinesslayer
    {
        private ISchoolDataAccesslayer _isd;
        public StudentBusinesslayer(ISchoolDataAccesslayer isd)
        {
            _isd = isd;
        }
        public School GetSchoolInfo()
        {
            return _isd.GetSchoolInfo;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySecondWebAPI.Models
{
    public class Product
    {
        public int id { get; set; }
        public string name{ get; set; }
        public double  price{ get; set; }
        public int Quntity{ get; set; }
    }
}
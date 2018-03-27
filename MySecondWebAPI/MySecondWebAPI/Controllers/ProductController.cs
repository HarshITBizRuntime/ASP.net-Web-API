using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Web.Http;
using MySecondWebAPI.Models;

namespace MySecondWebAPI.Controllers
{
    public class ProductController : ApiController
    {

        private List<Product> products = new List<Product>()
        {
                new Product { id= 1, name= "Product 1", price= 50.5, Quntity=5},
                new Product { id= 2, name= "Product 2", price= 100.20, Quntity=2}

        };
        ContentType ct  = new ContentType("application/xml");
        public IEnumerable<Product> Get()
        {
            return products.ToList();

        }

       
        public IHttpActionResult GetProducts(int id)
        {
            var product = products.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }


    }
}

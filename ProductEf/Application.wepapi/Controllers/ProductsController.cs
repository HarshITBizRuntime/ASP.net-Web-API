using ApplicationService.servicess;
using System.Data.SqlClient;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;
using Application.Data;
using System.Collections.Generic;

namespace Application.wepapi.Controllers
{
    public class ProductsController : ApiController
    {
        private IProductServicess ps = new ProductServicess();

        public IEnumerable<Product> Get()
        {
            return ps.GetProduct();
        }
        public IHttpActionResult Get(int id)
        {
            var pro = ps.GetProduct(id);
            if (pro == null)
            {
                return NotFound();
            }
            return Ok(pro);
        }
    }

}

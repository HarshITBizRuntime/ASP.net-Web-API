using ApplicationService.servicess;
using Application.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ApplicationService.servicess
{
    public class ProductServicess : IProductServicess
    {
        private ProductDBEntities db = new ProductDBEntities();
        public List<Product> GetProduct()
        {
            return db.Products.ToList();
        }
        public Product GetProduct(int id)
        {
            return db.Products.Where(x => x.ID == id).FirstOrDefault();
        }
    }
}
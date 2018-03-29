using Application.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ApplicationService.servicess
{
    public interface IProductServicess
    {
        List<Product> GetProduct();
        Product GetProduct(int id);
    }
}

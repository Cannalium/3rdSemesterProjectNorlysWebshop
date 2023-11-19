using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    internal interface IProductAccess
    {
        List<Product> GetProductAll();
        int CreateProduct(Product product);
        bool UpdateProduct(Product productUpdate);
        Product GetProductById(int id);
        bool DeleteProduct(int prodId);
     
    }
}

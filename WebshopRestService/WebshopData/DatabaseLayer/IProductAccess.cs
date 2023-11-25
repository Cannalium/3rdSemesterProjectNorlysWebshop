using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IProductAccess
    {
        List<Product> GetProductAll();
        int CreateProduct(Product aProduct);
        bool UpdateProduct(Product productUpdate);
        List<Product> GetProductByType(string prodType);
        Product GetProductById(int prodId);
        bool DeleteProduct(int prodId);
     
    }
}

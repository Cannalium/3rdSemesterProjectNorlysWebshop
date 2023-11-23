using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopClientDesktop.ModelLayer;

namespace WebshopClientDesktop.ServiceLayer
{
    public interface IProductAccess
    {
        Task<List<Product>>? GetProducts(int id = -1);
        Task<int> CreateProduct(Product product);
    }
}

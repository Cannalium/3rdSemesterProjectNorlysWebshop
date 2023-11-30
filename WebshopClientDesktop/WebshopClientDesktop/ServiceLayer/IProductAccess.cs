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
        Task<List<Product>> GetAllProductsByType(string prodType);
        Task<List<Product>> GetAllProducts();
        Task<int> CreateProduct(Product productToSave);
        Task<bool> DeleteProduct (int prodId);
        Task<bool> UpdateProduct(Product productToUpdate);
    }
}

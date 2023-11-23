using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopClientDesktop.ModelLayer;
using WebshopClientDesktop.ServiceLayer;

namespace WebshopClientDesktop.ControlLayer
{
    public class ProductControl
    {

        readonly IProductAccess _productAccess;

        public ProductControl()
        {
            _productAccess = new ProductServiceAccess();

        }

        public async Task<List<Product>?> GetAllProducts()
        {
            List<Product>? foundProducts = null;
            if (_productAccess != null)
            {
                foundProducts = await _productAccess.GetProducts();

            }
            return foundProducts;

        }

        public async Task<int> CreateProduct(string? prodName, string? prodDescription, decimal prodPrice, int prodQuantity, string? prodType)
        {
            Product newProduct = new(prodName, prodDescription, prodPrice, prodQuantity, prodType);
            int insertedId = await _productAccess.CreateProduct(newProduct);
            return insertedId;
        }
    }
}

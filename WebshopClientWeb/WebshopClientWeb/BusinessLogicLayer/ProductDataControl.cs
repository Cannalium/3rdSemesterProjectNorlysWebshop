using System.Net;
using WebshopClientWeb.Logging;
using WebshopClientWeb.Model;
using WebshopClientWeb.ServiceLayer;

namespace WebshopClientWeb.BusinessLogicLayer
{
    public class ProductDataControl
    {
        readonly IProductServiceAccess _ProductAccess;

        public HttpStatusCode CurrentHttpStatusCode { get; set; }

        public ProductDataControl()
        {
            _ProductAccess = new ProductServiceAccess();
        }

        // Asynchronously retrieves all products using the ProductAccess service and logs the action
        public async Task<List<Product>> GetAllProducts()
        {
            Logger.LogInfo($"Getting all products");
            return await _ProductAccess.GetAllProducts();
        }

        // Asynchronously retrieves a product by ID using the ProductAccess service and logs the action
        public async Task<Product> GetProdById(int prodId)
        {
            Logger.LogInfo($"Getting product by ID");
            Product foundProduct = await _ProductAccess.GetProdById(prodId);
            return foundProduct;
        }
    }
}

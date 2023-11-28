using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public async Task<List<Product>> GetAllProductsByType(string type)
        {
            Logger.LogInfo($"Getting all products by type. Type: {type}");
            return await _ProductAccess.GetAllProductsByType(type);

        }

        public async Task<List<Product>> GetAllProducts()
        {
            Logger.LogInfo($"Getting all products");
            return await _ProductAccess.GetAllProducts();
        }
    }
}

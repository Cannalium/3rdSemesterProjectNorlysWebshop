using Microsoft.AspNetCore.Mvc;
using System.Net;
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

        public async Task<List<Product>> GetProducts()
        {
            List<Product> products = await _ProductAccess.GetProducts();
            return products;
        }
    }
}

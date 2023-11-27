﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopClientDesktop.Logging;
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

        private async Task<List<Product>> GetAllProductsByType(string type)
        {
            Logger.LogInfo($"Getting all products by type. Type: {type}");
            return await _productAccess.GetAllProductsByType(type);

        }

        public async Task<List<Product>> GetAllProductsByEventType()
        {
            return await GetAllProductsByType("Event");
        }

        public async Task<List<Product>> GetAllProductsByMerchType()
        {
            return await GetAllProductsByType("Merch");
        }

        public async Task<int> CreateProduct(string prodName, string prodDescription, decimal prodPrice, int prodQuantity, string prodType)
        {
            Product newProduct = new(prodName, prodDescription, prodPrice, prodQuantity, prodType);
            int insertedId = await _productAccess.CreateProduct(newProduct);
            return insertedId;
        }

        public async Task<bool> DeleteProduct(int prodId)
        {
            bool isDeleted = await _productAccess.DeleteProduct(prodId);
            return isDeleted;
        }

        public async Task<bool> UpdateProduct(Product updatedProduct)
        {
            bool isUpdated = await _productAccess.UpdateProduct(updatedProduct);
            return isUpdated;
        }
    }
}

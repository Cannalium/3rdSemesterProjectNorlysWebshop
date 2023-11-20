using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopModel.ModelLayer {
    public class Product {
    
        public Product() { }

        public Product(string prodName, string prodDescription, decimal prodPrice, int prodQuantity, string prodType) { }

        public Product(int prodId, string prodName, string prodDescription, decimal prodPrice, int prodQuantity, string prodType) 
        {
            ProdId = prodId;
            ProdName = prodName;
            ProdDescription = prodDescription;
            ProdPrice = prodPrice;
            ProdQuantity = prodQuantity;
            ProdType = prodType;
        }

        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string ProdDescription { get; set; }
        public decimal ProdPrice { get; set; }
        public int ProdQuantity { get; set; }
        public string ProdType { get; }
    }
}


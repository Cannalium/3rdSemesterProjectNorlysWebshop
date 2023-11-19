using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopModel.ModelLayer {
    public class Product {

        public Product(string prodName, string prodDescription, decimal prodPrice, int prodQuantity) {

            ProdName = prodName;
            ProdDescription = prodDescription;
            ProdPrice = prodPrice;
            ProdQuantity = prodQuantity;

        }

        public string ProdName { get; private set; }
        public string ProdDescription { get; private set; }
        public decimal ProdPrice { get; private set; }
        public int ProdQuantity { get; private set; }
    }
}


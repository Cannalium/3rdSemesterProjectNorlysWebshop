using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopClientDesktop.ModelLayer
{
    public class Product
    {
        public Product() { }

        public Product(string prodName, string prodDescription, decimal prodPrice, int prodQuantity, string prodType)
        {
            ProdName = prodName;
            ProdDescription = prodDescription;
            ProdPrice = prodPrice;
            ProdQuantity = prodQuantity;
            ProdType = prodType;
        }

        public Product(int prodId, string prodName, string prodDescription, decimal prodPrice, int prodQuantity, string prodType) : this(prodName, prodDescription, prodPrice, prodQuantity, prodType)
        {
            ProdId = prodId;
        }

        
        public string ProdName { get; set; }
        public string ProdDescription { get; set; }
        public decimal ProdPrice { get; set; }
        public int ProdQuantity { get; set; }
        public string ProdType { get; set; }
        public int ProdId { get; set; }

        public override string ToString()
        {
            return ProdName;
        }

    }
}

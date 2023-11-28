namespace WebshopClientWeb.Model
{
    public class Product
    {
            public Product() { }

            public Product(string? prodName, string? prodDescription, decimal prodPrice, int prodQuantity, string? prodType)
            {
                ProdName = prodName;
                ProdDescription = prodDescription;
                ProdPrice = prodPrice;
                ProdQuantity = prodQuantity;
                ProdType = prodType;
            }

            public Product(int prodId, string? prodName, string? prodDescription, decimal prodPrice, int prodQuantity, string? prodType) : this (prodName, prodDescription, prodPrice, prodQuantity, prodType)
            {
                ProdId = prodId;
            }

            public int ProdId { get; set; }
            public string? ProdName { get; set; }
            public string? ProdDescription { get; set; }
            public decimal ProdPrice { get; set; }
            public int ProdQuantity { get; set; }
            public string? ProdType { get; }
        }
    }


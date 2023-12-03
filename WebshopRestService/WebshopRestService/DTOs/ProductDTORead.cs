namespace WebshopRestService.DTOs {
    public class ProductDTORead
    {
        public ProductDTORead() { }

        public ProductDTORead(int prodId, string? prodName, string? prodDescription, decimal prodPrice, int prodQuantity, string? prodType) : this(prodName, prodDescription, prodPrice, prodQuantity, prodType )
        {
            ProdId = prodId;

        }

        public ProductDTORead(string? prodName, string? prodDescription, decimal prodPrice, int prodQuantity, string? prodType)
        {
            ProdName = prodName;
            ProdDescription = prodDescription;
            ProdPrice = prodPrice;
            ProdQuantity = prodQuantity;
            ProdType = prodType;
        }

        public int ProdId { get; set; }
        public string? ProdName { get; set; }
        public string? ProdDescription { get; set; }
        public decimal ProdPrice { get; set; }
        public int ProdQuantity { get; set; }
        public string? ProdType { get; set; }
          
    }
}


namespace WebshopRestService.DTOs 
{
    public class ProductDTOWrite 
    {
        public ProductDTOWrite() { }

        public ProductDTOWrite(int prodId, string? prodName, string? prodDescription, decimal prodPrice, int prodQuantity, string? prodType)
        {
            ProdId = prodId;
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

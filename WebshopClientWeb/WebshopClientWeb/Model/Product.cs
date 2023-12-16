using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebshopClientWeb.Model
{
    public class Product
    {
        public Product() { }

        public Product(int prodId, string? prodName, string? prodDescription, decimal prodPrice, int prodQuantity, string? prodType)
        {
            ProdId = prodId;
            ProdName = prodName;
            ProdDescription = prodDescription;
            ProdPrice = prodPrice;
            ProdQuantity = prodQuantity;
            ProdType = prodType;
        }

        [Key]
        public int ProdId { get; set; }

        [DisplayName("Titel :")]
        public string? ProdName { get; set; }

        [DisplayName("Beskrivelse :")]
        public string? ProdDescription { get; set; }

        [DisplayName("Pris :")]
        public decimal ProdPrice { get; set; }

        [DisplayName("Status :")]
        public int ProdQuantity { get; set; }
        public string? ProdType { get; }
    }
}


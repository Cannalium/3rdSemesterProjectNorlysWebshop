using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebshopClientWeb.Model
{
    public class Product


    {
            public Product(int prodId) 
            {
                ProdId = prodId;
            }

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


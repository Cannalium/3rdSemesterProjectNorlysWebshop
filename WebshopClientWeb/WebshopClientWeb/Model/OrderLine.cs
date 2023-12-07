using Microsoft.AspNetCore.Mvc;
using WebshopClientWeb.BusinessLogicLayer;
using WebshopClientWeb.Model;

namespace WebshopClientWeb.Model
{
    public class OrderLine
    {
        public OrderLine() { }
        public OrderLine(int prodId, int orderLineProdQuantity)
        {
            ProdId = prodId;
            OrderLineProdQuantity = orderLineProdQuantity;
        }
        public OrderLine(Product product, int orderLineProdQuantity) // husk at tilføje den tilbage som parameter int orderLineProdQuantity
        {
            OrderLineProdQuantity = orderLineProdQuantity;
            CartProduct = product;
        }

        public OrderLine(int orderLineId, int orderLineProdQuantity, Product product) : this(product, orderLineProdQuantity) //orderLineProdQuantity
        {
            OrderLineId = orderLineId;
        }

        public int ProdId { get; set; }
        public int OrderLineId { get; set; }
        public int OrderLineProdQuantity { get; set; }
        public Product CartProduct { get; set; }
    }
}

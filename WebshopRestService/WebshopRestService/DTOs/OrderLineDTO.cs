using WebshopModel.ModelLayer;

namespace WebshopRestService.DTOs 
{
    public class OrderLineDTO 
    {
        public OrderLineDTO() { }

        public OrderLineDTO(Product product, int orderLineProdQuantity) 
        {
            Product = product;
            OrderLineProdQuantity = orderLineProdQuantity;
        }

        public Product Product { get; set; }
        public int OrderLineProdQuantity { get; set; }
    }
}


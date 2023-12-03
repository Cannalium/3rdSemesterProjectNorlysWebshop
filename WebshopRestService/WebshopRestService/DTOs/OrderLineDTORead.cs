using WebshopModel.ModelLayer;

namespace WebshopRestService.DTOs 
{
    public class OrderLineDTORead 
    {
        public OrderLineDTORead() { }

        public OrderLineDTORead(Product product, int orderLineProdQuantity) 
        {
            Product = product;
            OrderLineProdQuantity = orderLineProdQuantity;
        }

        public Product Product { get; set; }
        public int OrderLineProdQuantity { get; set; }
    }
}


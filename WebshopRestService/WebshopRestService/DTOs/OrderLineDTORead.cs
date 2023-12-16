namespace WebshopRestService.DTOs
{
    public class OrderLineDTORead 
    {
        public OrderLineDTORead(int prodId, int orderLineProdQuantity) 
        {
            ProdId = prodId;
            OrderLineProdQuantity = orderLineProdQuantity;
        }

        public int ProdId { get; set; }
        public int OrderLineProdQuantity { get; set; }
    }
}


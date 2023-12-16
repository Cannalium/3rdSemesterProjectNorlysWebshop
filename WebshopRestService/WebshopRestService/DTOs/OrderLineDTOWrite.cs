namespace WebshopRestService.DTOs
{
    public class OrderLineDTOWrite 
    {
        public OrderLineDTOWrite(int prodId, int orderLineProdQuantity)
        { 
            OrderLineProdQuantity = orderLineProdQuantity;
            ProdId = prodId;  
        }

        public int OrderLineProdQuantity { get; set; }
        public int ProdId { get; set; }
    }
}


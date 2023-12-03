namespace WebshopRestService.DTOs
{
    public class OrderLineDTOWrite 
    {

        public OrderLineDTOWrite() { }

        public OrderLineDTOWrite(int orderLineProdQuantity)
        { 
            OrderLineProdQuantity = orderLineProdQuantity;
        }

        public int OrderLineProdQuantity { get; set; }
    }
}


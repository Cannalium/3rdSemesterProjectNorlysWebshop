namespace WebshopRestService.DTOs {
    public class OrderLineDTO {

        public OrderLineDTO() { }

        public OrderLineDTO(int orderLineId, int orderLineProdQuantity) 
        {
            OrderLineId = orderLineId;
            OrderLineProdQuantity = orderLineProdQuantity;
        }

        public int OrderLineId { get; set; }
        public int OrderLineProdQuantity { get; set; }
    }
}


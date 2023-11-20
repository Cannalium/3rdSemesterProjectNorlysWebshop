namespace WebshopRestService.DTOs
{
    public class OrderLineDataCreateDTO {

        public OrderLineDataCreateDTO() {
        }

        public OrderLineDataCreateDTO(int orderLineProdQuantity)
        { 
            OrderLineProdQuantity = orderLineProdQuantity;
        }

        public int OrderLineProdQuantity { get; set; }

    }
}


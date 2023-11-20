namespace WebshopRestService.DTOs
{
    public class OrderLineDataCreateDTO {

        public OrderLineDataCreateDTO() {
        }

        public OrderLineDataCreateDTO(int orderLineProdQuantity, decimal orderLinePrice) {
            OrderLineProdQuantity = orderLineProdQuantity;
            OrderLinePrice = orderLinePrice;
  
        }

        public int OrderLineProdQuantity { get; set; }
        public decimal OrderLinePrice { get; set; }

    }
}


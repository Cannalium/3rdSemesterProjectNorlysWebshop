namespace WebshopRestService.DTOs
{
    public class OrderLineDataCreateDTO {

        public OrderLineDataCreateDTO()
        {
        }

        public OrderLineDataCreateDTO(int orderLineProdQuantity, decimal orderLinePrice, string? prodName)
        {
            OrderLineProdQuantity = orderLineProdQuantity;
            OrderLinePrice = orderLinePrice;
            ProdName = prodName;
        }

        public int OrderLineProdQuantity { get; set; }
        public decimal OrderLinePrice { get; set; }

        public string? ProdName { get; set; }
    }
}


namespace WebshopRestService.DTO {
    public class OrderLineDTO {

        public OrderLineDTO() {
        }

        public OrderLineDTO(int orderLineId, int orderLineProdQuantity, decimal orderLinePrice, string? prodName) {
            OrderLineId = orderLineId;
            OrderLineProdQuantity = orderLineProdQuantity;
            OrderLinePrice = orderLinePrice;
            ProdName = prodName;
        }

        public int OrderLineId { get; set; }
        public int OrderLineProdQuantity { get; set; }
        public decimal OrderLinePrice { get; set; }

        public string? ProdName { get; set; }
    }
}


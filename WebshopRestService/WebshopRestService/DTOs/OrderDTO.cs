namespace WebshopRestService.DTOs
{
    public class OrderDTO 
    {
        public OrderDTO(){ }

        public OrderDTO(int orderId, DateTime orderDate) 
        { 
            OrderId = orderId;
            OrderDate = orderDate;
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}




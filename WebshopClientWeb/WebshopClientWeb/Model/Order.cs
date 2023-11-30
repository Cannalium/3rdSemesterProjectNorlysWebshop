namespace WebshopClientWeb.Model
{
    public class Order
    {
        public Order() { }

        public Order(int orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            OrderLines = new List<OrderLine>();
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();    
    }
}

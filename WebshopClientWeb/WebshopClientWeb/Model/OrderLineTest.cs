namespace WebshopClientWeb.Model
{
    public class OrderLineTest
    {
        public OrderLineTest(int prodId, int orderLineProdQuantity)
        {
            ProdId = prodId;
            OrderLineProdQuantity = orderLineProdQuantity;
        }
        public int ProdId { get; set; }
        public int OrderLineProdQuantity { get; set; }
    }
}

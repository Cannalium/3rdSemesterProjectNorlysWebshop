using WebshopClientWeb.Model;

namespace WebshopClientWeb.Model
{
    public class OrderLine
    {
        public OrderLine() { }

        public OrderLine(int orderLineProdQuantity) { }

        public OrderLine(int orderLineId, int orderLineProdQuantity)
        {
            OrderLineId = orderLineId;
            OrderLineProdQuantity = orderLineProdQuantity;

        }

        public int OrderLineId { get; set; }
        public int OrderLineProdQuantity { get; set; }
    }
}

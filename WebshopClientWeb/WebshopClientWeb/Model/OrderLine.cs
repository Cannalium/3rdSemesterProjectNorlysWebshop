namespace WebshopClientWeb.Model
{
    public class OrderLine
    {
        public OrderLine() { }

        public OrderLine(int prodId, int orderLineProdQuantity)
        {
            ProdId = prodId;
            OrderLineProdQuantity = orderLineProdQuantity;
        }
        public OrderLine(Product product, int orderLineProdQuantity)
        {
            OrderLineProdQuantity = orderLineProdQuantity;
            CartProduct = product;
        }

        public int ProdId { get; set; }
        public int OrderLineId { get; set; }
        public int OrderLineProdQuantity { get; set; }
        public Product CartProduct { get; set; }
    }
}

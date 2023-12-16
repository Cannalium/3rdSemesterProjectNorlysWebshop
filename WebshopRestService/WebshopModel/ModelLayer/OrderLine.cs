namespace WebshopModel.ModelLayer
{
    public class OrderLine 
    {
        public OrderLine() { }

        public OrderLine(int prodId, int orderLineProdQuantity) 
        {
            ProdId = prodId;
            OrderLineProdQuantity = orderLineProdQuantity;
        }

        public int OrderLineId { get; set; }
        public int ProdId { get; set; }
        public int OrderLineProdQuantity { get; set; }
    }
}


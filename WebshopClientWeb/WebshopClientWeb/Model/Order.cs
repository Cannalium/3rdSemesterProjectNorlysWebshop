namespace WebshopClientWeb.Model
{
    public class Order
    {
        public Person Person { get; set; }
        public decimal OrderPrice { get; set; }
        public List<OrderLine> OrderLines { get; set; }  

        public Order(Person person, decimal orderPrice, List<OrderLineTest> orderLines)
        {
            Person = person;
            OrderPrice = orderPrice;
            OrderLines = new List<OrderLine>();
        }  
    }
}

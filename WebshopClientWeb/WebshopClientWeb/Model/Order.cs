using Newtonsoft.Json;

namespace WebshopClientWeb.Model
{
    public class Order
    {
        public Order(Person person, decimal orderPrice, List<OrderLine> orderLines)
        {
            Person = person;
            OrderPrice = orderPrice;
            OrderLines = orderLines;
        }  
        
        [JsonProperty("PersonDTORead")]
        public Person Person { get; set; }
        public decimal OrderPrice { get; set; }
        public List<OrderLine> OrderLines { get; set; }  
    }
}

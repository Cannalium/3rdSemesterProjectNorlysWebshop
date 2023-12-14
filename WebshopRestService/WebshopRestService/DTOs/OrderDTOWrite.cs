using WebshopModel.ModelLayer;

namespace WebshopRestService.DTOs 
{
    public class OrderDTOWrite
    {
        public int OrderId { get; set; }
        public PersonDTOWrite PersonDTO { get; set; }
        public decimal OrderPrice { get; set; }
        public List<OrderLineDTOWrite> OrderLines { get; set; }

        public OrderDTOWrite(int orderId, PersonDTOWrite personDTO, decimal orderPrice, List<OrderLineDTOWrite> orderLines)
        {
            OrderId = orderId;
            PersonDTO = personDTO;
            OrderPrice = orderPrice;
            OrderLines = orderLines;
        }
    }


    /*public class OrderDTOWrite 
    {
        public OrderDTOWrite(Person person, DateTime orderDate, List<OrderLine> orderLines, decimal orderPrice)
        {
            OrderDate = orderDate;
            Person = person;
            OrderLines = orderLines;
            OrderPrice = orderPrice;
        }

        public DateTime OrderDate { get; set; }
        public Person Person { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public decimal OrderPrice { get; set; }
    }*/
}

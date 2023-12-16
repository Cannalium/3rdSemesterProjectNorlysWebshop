namespace WebshopRestService.DTOs
{
    public class OrderDTOWrite
    {
        public OrderDTOWrite(int orderId, PersonDTORead personDTORead, decimal orderPrice, List<OrderLineDTOWrite> orderLines)
        {
            OrderId = orderId;
            PersonDTORead = personDTORead;
            OrderPrice = orderPrice;
            OrderLines = orderLines;
        }

        public int OrderId { get; set; }
        public PersonDTORead PersonDTORead { get; set; }
        public decimal OrderPrice { get; set; }
        public List<OrderLineDTOWrite> OrderLines { get; set; }
    }
}

namespace WebshopRestService.DTOs
{
    public class OrderDTORead
    {
        public OrderDTORead() { }

        public OrderDTORead(int orderId, DateTime orderDate, decimal orderPrice, int personId_FK)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            OrderPrice = orderPrice;
            PersonId_FK = personId_FK;
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int PersonId_FK { get; set; }
        public PersonDTORead Person { get; set; }
        public List<OrderLineDTORead> OrderLines { get; set; }
        public decimal OrderPrice { get; set; }
    }
}





namespace WebshopRestService.DTOs {

    public class OrderDataCreateDTO 
    {
        public OrderDataCreateDTO() { }
        public OrderDataCreateDTO(DateTime orderDate)
        {
            OrderDate = orderDate;
        }

        public DateTime OrderDate { get; set; }
    }
}

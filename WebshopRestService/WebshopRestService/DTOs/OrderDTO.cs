namespace WebshopRestService.DTOs
{
    public class OrderDTO {

        public OrderDTO(){
        }

        public OrderDTO(int orderId, DateTime orderDate, string? firstName, string? lastName, string? prodName) {

            OrderId = orderId;
            OrderDate = orderDate;
            FirstName = firstName;
            LastName = lastName;
            ProdName = prodName;
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

 
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string FullName {
            get {
                return $"{FirstName} {LastName}";
            }
        }

        public string? ProdName { get; set; }
    }
}




namespace WebshopRestService.DTOs
{
    public class OrderDataCreateDTO
    {

        public OrderDataCreateDTO() {
        }
            public OrderDataCreateDTO(DateTime orderDate, decimal orderPrice, string? firstName, string? lastName, string? prodName)
            {
                OrderDate = orderDate;
                OrderPrice = orderPrice;
                FirstName = firstName;
                LastName = lastName;
                ProdName = prodName;
            }

            public DateTime OrderDate { get; set; }
            public decimal OrderPrice { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? ProdName { get; set; }
        }
    }

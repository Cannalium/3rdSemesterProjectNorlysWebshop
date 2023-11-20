namespace WebshopRestService.DTOs
{
    public class OrderDataCreateDTO
    {

        public OrderDataCreateDTO() {
        }
            public OrderDataCreateDTO(DateTime orderDate, string? firstName, string? lastName, string? prodName)
            {
                OrderDate = orderDate;
                FirstName = firstName;
                LastName = lastName;
                ProdName = prodName;
            }

            public DateTime OrderDate { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public string? ProdName { get; set; }
        }
    }

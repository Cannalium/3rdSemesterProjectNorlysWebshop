using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class OrderDTOConversion
    {
        // Convert from Order objects to OrderDTO objects
        public static List<OrderDTORead>? FromOrderCollection(List<Order> inOrders)
        {
            List<OrderDTORead>? anOrderReadDTOList = null;
            if (inOrders != null)
            {
                anOrderReadDTOList = new List<OrderDTORead>();
                OrderDTORead? tempDTO;
                foreach (Order anOrder in inOrders)
                {
                    if (anOrder != null)
                    {
                        tempDTO = FromOrder(anOrder);
                        anOrderReadDTOList.Add(tempDTO);
                    }
                }
            }
            return anOrderReadDTOList;
        }

        // Convert from Order object to OrderDTO object
        public static OrderDTORead? FromOrder(Order inOrder)
        {
            OrderDTORead? anOrderReadDTO = null;
            if (inOrder != null)
            {
                anOrderReadDTO = new OrderDTORead(inOrder.OrderId, inOrder.OrderDate, inOrder.OrderPrice, inOrder.PersonId_FK);

                // Assuming there's a Person to PersonDTO mapping method
                //anOrderReadDTO.Person = PersonDTOConversion.FromPerson(inOrder.Person);

                // Additional mapping or assignments for other properties
            }
            return anOrderReadDTO;
        }

            public static Order ToOrder(OrderDTOWrite inDTO)
            { 
                Order anOrder = null;
                if (inDTO != null)
                {

                // Convert OrderLines from List<OrderLineDTOWrite> to List<OrderLine>
                List<OrderLine?> orderLines = inDTO.OrderLines.Select(olDTO =>
                    OrderLineDTOConversion.ToOrderLine(olDTO)  // Convert OrderLineDTOWrite to OrderLine
                ).ToList();

                // Accessing PersonDTO property from the input OrderDTOWrite object
                PersonDTOWrite personDTO = inDTO.PersonDTO;

                // Using the ToPerson method from PersonDTOConversion class to convert PersonDTOWrite to Person
                Person? person = PersonDTOConversion.ToPerson(personDTO);

                anOrder = new Order(
                        orderPrice: inDTO.OrderPrice,
                        person: person,
                        orderLines: orderLines
                    );

                    // Additional mapping or assignments for other properties
                }
                return anOrder;
            }


        // Convert from OrderDTO object to Order object
        /*public static Order? ToOrder(OrderDTOWrite inDTO)
        {
            Order? anOrder = null;
            if (inDTO != null)
            {
                anOrder = new Order(); // ALT FORSVINDER HER

                // Assuming there's a PersonDTO to Person mapping method
                anOrder.Person = new Person {PersonId = inDTO.Person.PersonId};
                //anOrder.OrderDate = inDTO.OrderDate; // Map the orderDate property
                //anOrder.OrderPrice = inDTO.OrderPrice; // Map the orderPrice property

                // Additional mapping or assignments for other properties
            }
            return a*/


    }
}


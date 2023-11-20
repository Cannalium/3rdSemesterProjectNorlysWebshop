using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class OrderDTOCoversion
    {
        // Convert from Order objects to OrderDTO objects
        public static List<OrderDTO>? FromOrderCollection(List<Order> inOrders)
        {
            List<OrderDTO>? anOrderReadDTOList = null;
            if (inOrders != null)
            {
                anOrderReadDTOList = new List<OrderDTO>();
                OrderDTO? tempDTO;
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

        // Convert from Person object to PersonDTO object
        public static OrderDTO? FromOrder(Order inOrder)
        {
            OrderDTO? anOrderReadDTO = null;
            if (inOrder != null)
            {
                anOrderReadDTO = new OrderDTO(inOrder.OrderId, inOrder.OrderDate, inOrder.FirstName, inOrder.LastName, inOrder.ProdName);
            }
            return anOrderReadDTO;
        }

        // Convert from PersonDTO object to Person object
        public static Person? ToPerson(PersonDTO inDTO)
        {
            Person? aPerson = null;
            if (inDTO != null)
            {
                aPerson = new Person(inDTO.FirstName, inDTO.LastName, inDTO.PhoneNo, inDTO.Email, inDTO.PersonType);
            }
            return aPerson;
        }
    }
}
}

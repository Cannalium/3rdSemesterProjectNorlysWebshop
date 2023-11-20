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

        // Convert from Order object to OrderDTO object
        public static OrderDTO? FromOrder(Order inOrder)
        {
            OrderDTO? anOrderReadDTO = null;
            if (inOrder != null)
            {
                anOrderReadDTO = new OrderDTO(inOrder.OrderId, inOrder.OrderDate);
            }
            return anOrderReadDTO;
        }

        // Convert from OrderDTO object to Order object
        public static Order? ToOrder(OrderDTO inDTO)
        {
            Order? anOrder = null;
            if (inDTO != null)
            {
                anOrder = new Order(inDTO.OrderId, inDTO.OrderDate);
            }
            return anOrder;
        }
    }
}
}

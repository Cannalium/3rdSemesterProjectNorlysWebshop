using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class OrderDTOConversion
    {
        // Convert from Order objects to OrderDTO objects
        public static List<OrderDTORead>? FromOrderCollection(List<Order> orders)
        {
            List<OrderDTORead>? orderDTOReadList = null;
            if (orders != null)
            {
                orderDTOReadList = new List<OrderDTORead>();
                OrderDTORead? tempDTO;
                foreach (Order anOrder in orders)
                {
                    if (anOrder != null)
                    {
                        tempDTO = FromOrder(anOrder);
                        orderDTOReadList.Add(tempDTO);
                    }
                }
            }
            return orderDTOReadList;
        }

        // Convert from Order object to OrderDTO object
        public static OrderDTORead? FromOrder(Order order)
        {
            OrderDTORead? anOrderDTORead = null;
            if (order != null)
            {
                anOrderDTORead = new OrderDTORead(order.OrderId, order.OrderDate, order.OrderPrice, order.PersonId_FK);
            }
            return anOrderDTORead;
        }

        // Convert from OrderDTO object to Order object
        public static Order ToOrder(OrderDTOWrite inDTO)
        {
            Order anOrder = null;
            if (inDTO != null)
            {
                // Convert OrderLines from List<OrderLineDTOWrite> to List<OrderLine>
                List<OrderLine?> orderLines = inDTO.OrderLines.Select(orderLineDTO =>
                    OrderLineDTOConversion.ToOrderLine(orderLineDTO)  // Convert OrderLineDTOWrite to OrderLine
                ).ToList();

                // Convert person from personDTORead to person
                Person? person = PersonDTOConversion.ToPerson(inDTO.PersonDTORead);

                anOrder = new Order(orderPrice: inDTO.OrderPrice, person: person, orderLines: orderLines);
            }
            return anOrder;
        }
    }
}


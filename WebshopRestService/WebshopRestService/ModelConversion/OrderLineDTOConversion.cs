using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class OrderLineDTOConversion
    {
        // Convert from OrderLine objects to OrderLineDTO objects
        public static List<OrderLineDTORead>? FromOrderLineCollection(List<OrderLine> orderLines)
        {
            List<OrderLineDTORead>? orderLineDTOReadList = null;
            if (orderLines != null)
            {
                orderLineDTOReadList = new List<OrderLineDTORead>();
                OrderLineDTORead? tempDTO;
                foreach (OrderLine anOrderLine in orderLines)
                {
                    if (anOrderLine != null)
                    {
                        tempDTO = FromOrderLine(anOrderLine);
                        orderLineDTOReadList.Add(tempDTO);
                    }
                }
            }
            return orderLineDTOReadList;
        }

        // Convert from OrderLine object to OrderLineDTO object
        public static OrderLineDTORead? FromOrderLine(OrderLine inOrderLine)
        {
            OrderLineDTORead? anOrderLineDTORead = null;
            if (inOrderLine != null)
            {
                anOrderLineDTORead = new OrderLineDTORead(inOrderLine.ProdId, inOrderLine.OrderLineProdQuantity);
            }
            return anOrderLineDTORead;
        }

        // Convert from OrderLineDTO object to OrderLine object
        public static OrderLine? ToOrderLine(OrderLineDTOWrite inDTO)
        {
            OrderLine? anOrderLine = null;
            if (inDTO != null)
            {
                anOrderLine = new OrderLine(inDTO.ProdId, inDTO.OrderLineProdQuantity);
            }
            return anOrderLine;
        }
    }
}


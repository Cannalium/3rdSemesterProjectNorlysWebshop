using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class OrderLineDTOConversion
    {
        // Convert from OrderLine objects to OrderLineDTO objects
        public static List<OrderLineDTORead>? FromOrderLineCollection(List<OrderLine> inOrderLines)
        {
            List<OrderLineDTORead>? anOrderLineReadDTOList = null;
            if (inOrderLines != null)
            {
                anOrderLineReadDTOList = new List<OrderLineDTORead>();
                OrderLineDTORead? tempDTO;
                foreach (OrderLine anOrderLine in inOrderLines)
                {
                    if (anOrderLine != null)
                    {
                        tempDTO = FromOrderLine(anOrderLine);
                        anOrderLineReadDTOList.Add(tempDTO);
                    }
                }
            }
            return anOrderLineReadDTOList;
        }

        // Convert from OrderLine object to OrderLineDTO object
        public static OrderLineDTORead? FromOrderLine(OrderLine inOrderLine)
        {
            OrderLineDTORead? anOrderLineReadDTO = null;
            if (inOrderLine != null)
            {
                anOrderLineReadDTO = new OrderLineDTORead(inOrderLine.ProdId, inOrderLine.OrderLineProdQuantity);
            }
            return anOrderLineReadDTO;
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


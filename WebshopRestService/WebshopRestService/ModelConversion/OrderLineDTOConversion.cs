using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.ModelConversion
{
    public class OrderLineDTOConversion
    {
        public class OrderLineDTOCoversion
        {
            // Convert from OrderLine objects to OrderLineDTO objects
            public static List<OrderLineDTO>? FromOrderLineCollection(List<OrderLine> inOrderLines)
            {
                List<OrderLineDTO>? anOrderLineReadDTOList = null;
                if (inOrderLines != null)
                {
                    anOrderLineReadDTOList = new List<OrderLineDTO>();
                    OrderLineDTO? tempDTO;
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
            public static OrderLineDTO? FromOrderLine(OrderLine inOrderLine)
            {
                OrderLineDTO? anOrderLineReadDTO = null;
                if (inOrderLine != null)
                {
                    anOrderLineReadDTO = new OrderLineDTO(inOrderLine.OrderLineId, inOrderLine.OrderLineProdQuantity);
                }
                return anOrderLineReadDTO;
            }

            // Convert from OrderLineDTO object to OrderLine object
            public static OrderLine? ToOrderLine(OrderLineDTO inDTO)
            {
                OrderLine? anOrderLine = null;
                if (inDTO != null)
                {
                    anOrderLine = new OrderLine(inDTO.OrderLineId);
                }
                return anOrderLine;
            }
        }
    }
}

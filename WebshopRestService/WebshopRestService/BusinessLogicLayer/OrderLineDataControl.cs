using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public class OrderLineDataControl : IOrderLineData
    {
        private readonly IOrderLineAccess _orderLineAccess;

        public OrderLineDataControl(IOrderLineAccess OrderLineAccess)
        {
            _orderLineAccess = OrderLineAccess;
        }

        public int Add(OrderLineDTORead orderLineToAdd)
        {
            int insertedId = 0;
            try
            {
                OrderLine? foundOrderLine = ModelConversion.OrderLineDTOConversion.ToOrderLine(orderLineToAdd);
                if (foundOrderLine != null)
                {
                    insertedId = _orderLineAccess.CreateOrderLine(foundOrderLine);
                }
            }
            catch
            {
                insertedId = -1;
            }
            return insertedId;
        }

        public bool Delete(int orderLineId)
        {
            try
            {
                bool deletionSuccessful = _orderLineAccess.DeleteOrderLine(orderLineId);
                return deletionSuccessful;
            }
            catch
            {
                return false;
            }
        }

        public OrderLineDTORead? Get(int orderLineId)
        {
            OrderLineDTORead? foundOrderLineDTO;
            try
            {
                OrderLine? foundOrderLine = _orderLineAccess.GetOrderLineById(orderLineId);
                foundOrderLineDTO = ModelConversion.OrderLineDTOConversion.FromOrderLine(foundOrderLine);
            }
            catch
            {
                foundOrderLineDTO = null;
            }
            return foundOrderLineDTO;
        }

        public List<OrderLineDTORead>? Get()
        {
            List<OrderLineDTORead>? foundDTOs;
            try
            {
                List<OrderLine>? foundOrderLines = _orderLineAccess.GetOrderLineAll();
                foundDTOs = ModelConversion.OrderLineDTOConversion.FromOrderLineCollection(foundOrderLines);
            }
            catch
            {
                foundDTOs = null;
            }
            return foundDTOs;
        }

        public bool Put(OrderLineDTORead orderLineToUpdate)
        {
            try
            {
                OrderLine? updatedOrderLine = ModelConversion.OrderLineDTOConversion.ToOrderLine(orderLineToUpdate);

                if (updatedOrderLine != null)
                {
                    bool updateSuccessful = _orderLineAccess.UpdateOrderLine(updatedOrderLine);
                    return updateSuccessful;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}

using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
using WebshopRestService.DTO;

namespace WebshopRestService.BusinessLogicLayer
{
    public class OrderLineDataControl : IOrderLineData
    {
        private readonly IOrderLineAccess _orderLineAccess;

        public OrderLineDataControl(IOrderLineAccess inOrderLineAccess)
        {
            _orderLineAccess = inOrderLineAccess;
        }

        public int Add(OrderLineDTO orderLineToAdd)
        {
            int insertedId = 0;
            try
            {
                OrderLine? foundOrderLine = ModelConversion.OrderLineDTOConvert.ToOrderLine(orderLineToAdd);
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

        public OrderLineDTO? Get(int orderLineId)
        {
            OrderLineDTO? foundOrderLineDTO;
            try
            {
                OrderLine? foundOrderLine = _orderLineAccess.GetOrderLineById(orderLineId);
                foundOrderLineDTO = ModelConversion.OrderLineDTOConvert.FromOrderLine(foundOrderLine);
            }
            catch
            {
                foundOrderLineDTO = null;
            }
            return foundOrderLineDTO;
        }

        public List<OrderLineDTO>? Get()
        {
            List<OrderLineDTO>? foundDTOs;
            try
            {
                List<OrderLine>? foundOrderLines = _orderLineAccess.GetOrderLineAll();
                foundDTOs = ModelConversion.OrderLineDTOConvert.FromOrderLineCollection(foundOrderLines);
            }
            catch
            {
                foundDTOs = null;
            }
            return foundDTOs;
        }

        public bool Put(OrderLineDTO orderLineToUpdate)
        {
            try
            {
                OrderLine? updatedOrderLine = ModelConversion.OrderLineDTOConvert.ToOrderLine(orderLineToUpdate);

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

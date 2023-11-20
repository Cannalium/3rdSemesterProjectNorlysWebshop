using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;

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
                OrderLine? foundOrderLine = ModelConversion.OrderLineDtoConvert.ToOrderLine(newOrderLine);
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

        public bool Delete(int id)
        {
            try
            {
                bool deletionSuccessful = _orderLineAccess.DeleteOrderLine(id);

                return deletionSuccessful;
            }
            catch
            {
                return false;
            }
        }

        public OrderLineDTO? Get(int id)
        {
            OrderLineDTO? foundOrderLineDto;
            try
            {
                OrderLine? foundOrderLine = _orderLineAccess.GetOrderLineById(idToMatch);
                foundOrderLineDto = ModelConversion.OrderLineDtoConvert.FromOrderLine(foundOrderLine);
            }
            catch
            {
                foundOrderLineDto = null;
            }
            return foundOrderLineDto;

        }

        public List<OrderLineDTO>? Get()
        {
            List<OrderLineDTO>? foundDtos;
            try
            {
                List<OrderLine>? foundOrderLines = _orderLineAccess.GetOrderLineAll();
                foundDtos = ModelConversion.OrderLineDtoConvert.FromOrderLineCollection(foundOrderLines);
            }
            catch
            {
                foundDtos = null;
            }
            return foundDtos;

        }

        public bool Put(OrderLineDTO orderLineToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

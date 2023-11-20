using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;

namespace WebshopRestService.BusinessLogicLayer
{
    public class OrderDataControl : IOrderData
    {
        private readonly IOrderAccess _orderAccess;

        public OrderDataControl(IOrderAccess inOrderAccess)
        {
            _orderAccess = inOrderAccess;

        }

        public int Add(OrderDTO orderToAdd)
        {
            int insertedId = 0;
            try
            {
                Order? foundOrder = ModelConversion.OrderDtoConvert.ToOrder(newOrder);
                if (foundOrder != null)
                {
                    insertedId = _orderAccess.CreateOrder(foundOrder);
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
                bool deletionSuccessful = _orderAccess.DeleteOrder(id);

                return deletionSuccessful;
            }
            catch
            {
                return false;
            }
        }

        public OrderDTO? Get(int id)
        {
            OrderDTO? foundOrderDto;
            try
            {
                Order? foundOrder = _orderAccess.GetOrderById(idToMatch);
                foundOrderDto = ModelConversion.OrderDtoConvert.FromOrder(foundOrder);
            }
            catch
            {
                foundOrderDto = null;
            }
            return foundOrderDto;
        }

        public List<OrderDTO>? Get()
        {
            List<OrderDTO>? foundDtos;
            try
            {
                List<Order>? foundOrders = _orderAccess.GetOrderAll();
                foundDtos = ModelConversion.OrderDtoConvert.FromOrderCollection(foundOrders);
            }
            catch
            {
                foundDtos = null;
            }
            return foundDtos;
        }

        public bool Put(OrderDTO orderToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

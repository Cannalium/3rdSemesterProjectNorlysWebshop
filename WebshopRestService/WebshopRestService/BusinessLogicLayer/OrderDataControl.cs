using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
using WebshopRestService.DTO;

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
                Order? foundOrder = ModelConversion.OrderDTOConvert.ToOrder(orderToAdd);
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

        public bool Delete(int orderId)
        {
            try
            {
                bool deletionSuccessful = _orderAccess.DeleteOrder(orderId);
                return deletionSuccessful;
            }
            catch
            {
                return false;
            }
        }

        public OrderDTO? Get(int orderId)
        {
            OrderDTO? foundOrderDTO;
            try
            {
                Order? foundOrder = _orderAccess.GetOrderById(orderId);
                foundOrderDTO = ModelConversion.OrderDTOConvert.FromOrder(foundOrder);
            }
            catch
            {
                foundOrderDTO = null;
            }
            return foundOrderDTO;
        }

        public List<OrderDTO>? Get()
        {
            List<OrderDTO>? foundDtos;
            try
            {
                List<Order>? foundOrders = _orderAccess.GetOrderAll();
                foundDtos = ModelConversion.OrderDTOConvert.FromOrderCollection(foundOrders);
            }
            catch
            {
                foundDtos = null;
            }
            return foundDtos;
        }

        public bool Put(OrderDTO orderToUpdate)
        {
            try
            {
                Order? updatedOrder = ModelConversion.OrderDTOConvert.ToOrder(orderToUpdate);

                if (updatedOrder != null)
                {
                    bool updateSuccessful = _orderAccess.UpdateOrder(updatedOrder);
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

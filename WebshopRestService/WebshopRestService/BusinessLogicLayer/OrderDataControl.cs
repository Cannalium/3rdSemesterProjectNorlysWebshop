using WebshopData.DatabaseLayer;
using WebshopModel.ModelLayer;
using WebshopRestService.DTOs;
using WebshopRestService.Logging;

namespace WebshopRestService.BusinessLogicLayer
{
    public class OrderDataControl : IOrderData
    {
        private readonly IOrderAccess _orderAccess;

        public OrderDataControl(IOrderAccess OrderAccess)
        {
            _orderAccess = OrderAccess;
        }

        public int Add(OrderDTOWrite orderToAdd)
        {
            int insertedId = 0;
            try
            {
                if (orderToAdd != null && orderToAdd.Person != null)
                {
                    Order? foundOrder = ModelConversion.OrderDTOConversion.ToOrder(orderToAdd);
                    if (foundOrder != null && foundOrder.Person != null)
                    {
                        insertedId = _orderAccess.CreateOrder(foundOrder);
                    }
                    else
                    {
                        // Log or handle the case where foundOrder or foundOrder.Person is null.
                        Console.WriteLine("Error: foundOrder or foundOrder.Person is null.");
                        insertedId = -1;
                    }
                }
                else
                {
                    // Log or handle the case where orderToAdd or orderToAdd.Person is null.
                    Console.WriteLine("Error: orderToAdd or orderToAdd.Person is null.");
                    insertedId = -1;
                }
            }
            catch (Exception ex)
            {
                // Log the exception for further investigation.
                Console.WriteLine($"Exception: {ex.Message}");
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

        public OrderDTORead? Get(int orderId)
        {
            OrderDTORead? foundOrderDTO;
            try
            {
                Order? foundOrder = _orderAccess.GetOrderById(orderId);
                foundOrderDTO = ModelConversion.OrderDTOConversion.FromOrder(foundOrder);
            }
            catch(Exception ex)
            {
                foundOrderDTO = null;
                Logger.LogError(ex);
            }
            return foundOrderDTO;
        }

        public List<OrderDTORead>? Get()
        {
            List<OrderDTORead>? foundDtos;
            try
            {
                List<Order>? foundOrders = _orderAccess.GetOrderAll();
                foundDtos = ModelConversion.OrderDTOConversion.FromOrderCollection(foundOrders);
            }
            catch
            {
                foundDtos = null;
            }
            return foundDtos;
        }

        public bool Put(OrderDTOWrite orderToUpdate)
        {
            try
            {
                Order? updatedOrder = ModelConversion.OrderDTOConversion.ToOrder(orderToUpdate);

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

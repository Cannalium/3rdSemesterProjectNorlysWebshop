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

        public int CreateOrder(OrderDTOWrite orderToCreate)
        {
            int insertedId = -1;
            try
            {
                if (orderToCreate != null && orderToCreate.PersonDTORead != null)
                {
                    Order? foundOrder = ModelConversion.OrderDTOConversion.ToOrder(orderToCreate);
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
    }
}

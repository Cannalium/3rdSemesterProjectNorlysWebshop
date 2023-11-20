using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public interface IOrderData
    {
        OrderDTO? Get(int ordedrId);
        List<OrderDTO>? Get();
        int Add(OrderDTO orderToAdd);
        bool Put(OrderDTO orderToUpdate);
        bool Delete(int orderId);
    }
}

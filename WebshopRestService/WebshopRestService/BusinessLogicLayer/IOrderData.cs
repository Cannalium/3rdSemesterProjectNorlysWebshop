using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public interface IOrderData
    {
        OrderDTORead? Get(int orderId);
        List<OrderDTORead>? Get();
        int Add(OrderDTOWrite orderToAdd);
        bool Put(OrderDTOWrite orderToUpdate);
        bool Delete(int orderId);
    }
}

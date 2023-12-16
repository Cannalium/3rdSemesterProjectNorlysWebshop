using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public interface IOrderData
    {
        int CreateOrder(OrderDTOWrite orderToCreate);
    }
}

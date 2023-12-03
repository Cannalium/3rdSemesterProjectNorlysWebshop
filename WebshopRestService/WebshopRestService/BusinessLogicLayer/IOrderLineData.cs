using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public interface IOrderLineData
    {
        OrderLineDTORead? Get(int orderLineId);
        List<OrderLineDTORead>? Get();
        int Add(OrderLineDTORead orderLineToAdd);
        bool Put(OrderLineDTORead orderLineToUpdate);
        bool Delete(int orderLineId);
    }
}

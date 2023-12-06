using WebshopRestService.DTOs;

namespace WebshopRestService.BusinessLogicLayer
{
    public interface IOrderLineData
    {
        OrderLineDTORead? Get(int orderLineId);
        List<OrderLineDTORead>? Get();
        int Add(OrderLineDTOWrite orderLineToAdd);
        bool Put(OrderLineDTOWrite orderLineToUpdate);
        bool Delete(int orderLineId);
    }
}

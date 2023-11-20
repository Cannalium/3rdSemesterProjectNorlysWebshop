namespace WebshopRestService.BusinessLogicLayer
{
    public interface IOrderLineData
    {
        OrderLineDTO? Get(int orderLineId);
        List<OrderLineDTO>? Get();
        int Add(OrderLineDTO orderLineToAdd);
        bool Put(OrderLineDTO orderLineToUpdate);
        bool Delete(int orderLineId);

    }
}

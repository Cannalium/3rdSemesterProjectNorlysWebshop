namespace WebshopRestService.BusinessLogicLayer
{
    public interface IOrderLineData
    {
        OrderLineDTO? Get(int id);
        List<OrderLineDTO>? Get();
        int Add(OrderLineDTO orderLineToAdd);
        bool Put(OrderLineDTO orderLineToUpdate);
        bool Delete(int id);

    }
}

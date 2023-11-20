namespace WebshopRestService.BusinessLogicLayer
{
    public interface IOrderData
    {
        OrderDTO? Get(int id);
        List<OrderDTO>? Get();
        int Add(OrderDTO orderToAdd);
        bool Put(OrderDTO orderToUpdate);
        bool Delete(int id);

    }
}

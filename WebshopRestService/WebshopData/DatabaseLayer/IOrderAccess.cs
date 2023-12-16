using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IOrderAccess
    {
        int CreateOrder(Order orderToCreate);
        List<Order> GetAllOrders();
        Order GetOrderById(int orderId);
        bool UpdateOrder(Order orderToUpdate);
        bool DeleteOrder(int orderId);
    }
}

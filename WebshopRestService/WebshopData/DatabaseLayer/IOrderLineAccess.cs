using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IOrderLineAccess
    {
        int CreateOrderLine(OrderLine orderLineToCreate);
        OrderLine GetOrderLineById(int orderLineId);
        bool UpdateOrderLine(OrderLine orderLineToUpdate);
        bool DeleteOrderLine(int orderLineId);
    }
}

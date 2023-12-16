using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IOrderAccess
    {
        int CreateOrder(Order orderToCreate);
    }
}

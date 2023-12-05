using WebshopClientWeb.Model;

namespace WebshopClientWeb.ServiceLayer
{
    public interface IOrderServiceAccess
    {
        Task<int> CreateOrder(Order orderToCreate);
    }
}

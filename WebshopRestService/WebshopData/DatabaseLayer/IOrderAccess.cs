using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    public interface IOrderAccess
    {
        List<Order> GetOrderAll();
        int CreateOrder(Order anOrder);
        bool UpdateOrder(Order orderUpdate);
        Order? GetOrderById(int orderId);
        bool DeleteOrder(int orderId);

    }
}

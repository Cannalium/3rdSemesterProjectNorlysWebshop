using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebshopModel.ModelLayer;

namespace WebshopData.DatabaseLayer
{
    internal interface IOrderLineAccess
    {
        List<OrderLine> GetOrderLineAll();
        int CreateOrderLine(OrderLine anOrderLine);
        bool UpdateOrderLine(OrderLine orderLineUpdate);
        OrderLine GetOrderLineById(int orderLineId);
        bool DeleteOrderLine(int orderLineId);

    }
}

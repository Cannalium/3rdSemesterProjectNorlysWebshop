using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopModel.ModelLayer {
    public class Order {

        public Order() { }

        public Order(int orderId, DateTime orderDate) {

            OrderId = orderId;
            OrderDate = orderDate;
            
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}

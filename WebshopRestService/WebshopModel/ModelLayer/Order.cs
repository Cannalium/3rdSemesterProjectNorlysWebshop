using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopModel.ModelLayer {
    public class Order {

        public Order() { }

        public Order(int orderId, DateTime orderDate, decimal orderPrice) {

            OrderId = orderId;
            OrderDate = orderDate;
            OrderPrice = orderPrice;
            
        }

        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }
    }
}

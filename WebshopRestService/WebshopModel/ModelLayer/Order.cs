using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopModel.ModelLayer {
    public class Order {

        public Order(DateTime orderDate, decimal orderPrice) {

            OrderDate = orderDate;
            OrderPrice = orderPrice;
            
        }

        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }
    }
}

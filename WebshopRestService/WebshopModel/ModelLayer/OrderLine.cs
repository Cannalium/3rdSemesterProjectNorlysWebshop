using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopModel.ModelLayer {
    public class OrderLine {

        public OrderLine() { }

        public OrderLine(int orderLineProdQuantity) { }

        public OrderLine(int orderLineId, int orderLineProdQuantity) {

            OrderLineId = orderLineId;
            OrderLineProdQuantity = orderLineProdQuantity;
            
        }

        public int OrderLineId { get; set; }
        public int OrderLineProdQuantity { get; set; }
    }
}


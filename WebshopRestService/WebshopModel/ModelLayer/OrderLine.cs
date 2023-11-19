using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopModel.ModelLayer {
    public class OrderLine {

        public OrderLine(int orderLineProdQuantity) {

            OrderLineProdQuantity = orderLineProdQuantity;    

        }

        public int OrderLineProdQuantity { get; set; }
    }
}


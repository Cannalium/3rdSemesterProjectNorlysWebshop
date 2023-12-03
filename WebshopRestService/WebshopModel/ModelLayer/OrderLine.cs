using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebshopModel.ModelLayer {
    public class OrderLine {

        public OrderLine() { }

        public OrderLine(Product product, int orderLineProdQuantity) 
        {
            Product = product;
            OrderLineProdQuantity = orderLineProdQuantity;
        }


        public int OrderLineId { get; set; }
        public Product Product { get; set; }
        public int OrderLineProdQuantity { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.avaCloud.Entidades
{
    public class Order :  EntityBase
    {
        public DateTime OrderDate { get; set; }

        public List<OrderItem> Orderitem  { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public override bool Validate()
        {
            return OrderItem.Count > 0; 
        }
    }
}

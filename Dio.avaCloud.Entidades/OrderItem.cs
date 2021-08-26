using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.avaCloud.Entidades
{
    public class OrderItem : EntityBase

    {
        public static int Count { get; internal set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                if(Product != null)
                    totalprice =  Product.Price * Quantity;
                return totalprice;
            }
        }
        public override bool Validate()
        {
            bool isValid=true;
            if (Quantity <= 0) 
                return isValid = false;
            if (Id <= 0) 
                return isValid = false;
            return true;
        }
    }
}

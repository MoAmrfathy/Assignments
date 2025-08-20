using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    public class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One Discount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return (price / 2) * (quantity / 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    public class NoDiscount : Discount
    {
        public NoDiscount()
        {
            Name = "No Discount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity) => 0;
    }
}

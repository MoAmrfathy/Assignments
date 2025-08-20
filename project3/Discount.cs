using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    public abstract class Discount
    {
        public string Name { get; protected set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
}

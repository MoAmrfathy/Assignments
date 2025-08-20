using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    public class RegularUser : User
    {
        public override Discount GetDiscount() => new PercentageDiscount(5);
    }
}

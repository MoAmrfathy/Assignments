using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    public class GuestUser : User
    {
        public override Discount GetDiscount() => new NoDiscount();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    public class FlatDiscount : Discount
    {
        private readonly decimal flatAmount;
        public FlatDiscount(decimal amount)
        {
            flatAmount = amount;
            Name = $"Flat ${flatAmount} Discount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return flatAmount * Math.Min(quantity, 1);
        }
    }
}

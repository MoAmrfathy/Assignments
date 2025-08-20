namespace project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user type (Regular / Premium / Guest):");
            string userType = Console.ReadLine();

            User user = userType.ToLower() switch
            {
                "regular" => new RegularUser { Name = "Regular User" },
                "premium" => new PremiumUser { Name = "Premium User" },
                _ => new GuestUser { Name = "Guest User" }
            };

            Console.WriteLine("Enter product price:");
            decimal.TryParse(Console.ReadLine(), out decimal price);

            Console.WriteLine("Enter product quantity:");
            int.TryParse(Console.ReadLine(), out int qty);

            Discount discount = user.GetDiscount();
            decimal discountAmount = discount.CalculateDiscount(price, qty);
            decimal totalPrice = price * qty - discountAmount;

            Console.WriteLine($"{user.Name} gets: {discount.Name}");
            Console.WriteLine($"Original Price: {price * qty}");
            Console.WriteLine($"Discount Amount: {discountAmount}");
            Console.WriteLine($"Final Price: {totalPrice}");
        }
    }
}

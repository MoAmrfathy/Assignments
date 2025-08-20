namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Add: {Maths.Add(10, 5)}");
            Console.WriteLine($"Subtract: {Maths.Subtract(10, 5)}");
            Console.WriteLine($"Multiply: {Maths.Multiply(10, 5)}");
            Console.WriteLine($"Divide: {Maths.Divide(10, 5)}");

        }
    }
}

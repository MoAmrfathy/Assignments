namespace Assignments.Session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            Console.WriteLine("Q1 - Print numbers from 1 to the given number");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Console.Write("Output: ");
                for (int i = 1; i <= num; i++)
                {
                    Console.Write(i);
                    if (i != num) Console.Write(", ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine();
            #endregion

            #region Q2 
            Console.WriteLine("Q2 - Multiplication Table (1 to 12)");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.Write("Output: ");
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write((number * i) + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine();
            #endregion

            #region Q3 
            Console.WriteLine("Q3 - Print Even Numbers up to the given number");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int limit))
            {
                Console.Write("Output: ");
                for (int i = 2; i <= limit; i += 2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine();
            #endregion

            #region Q4 
            Console.WriteLine("Q4 - Calculate power (base^exponent)");
            Console.Write("Enter base number: ");
            if (int.TryParse(Console.ReadLine(), out int baseNum))
            {
                Console.Write("Enter exponent: ");
                if (int.TryParse(Console.ReadLine(), out int exp))
                {
                    int result = 1;
                    for (int i = 1; i <= exp; i++)
                    {
                        result *= baseNum;
                    }
                    Console.WriteLine($"Result = {result}");
                }
                else
                {
                    Console.WriteLine("Invalid exponent!");
                }
            }
            else
            {
                Console.WriteLine("Invalid base number!");
            }
            Console.WriteLine();
            #endregion

            #region Q5
            Console.WriteLine("Q5 - Enter 5 subject marks and calculate total, average, percentage");
            int total = 0, mark;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Subject {i}: ");
                if (int.TryParse(Console.ReadLine(), out mark))
                {
                    total += mark;
                }
                else
                {
                    Console.WriteLine("Invalid input! Try again.");
                    i--;
                }
            }
            float average = total / 5f;
            Console.WriteLine($"Total Marks = {total}");
            Console.WriteLine($"Average Marks = {average}");
            Console.WriteLine($"Percentage = {average}%");
            Console.WriteLine();
            #endregion

            #region Q6 
            Console.WriteLine("Q6 - Reverse a String");
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string reversed = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine("Reversed string: " + reversed);
            Console.WriteLine();
            #endregion

            #region Q7 - Reverse integer
            Console.WriteLine("Q7 - Reverse an Integer");
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int no))
            {
                int reversedint = 0;
                while (no != 0)
                {
                    int digit = no % 10;
                    reversedint = reversedint * 10 + digit;
                    no /= 10;
                }
                Console.WriteLine("Reversed number: " + reversedint);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine();
            #endregion

            #region Q8 
            Console.WriteLine("Q8 - Prime numbers in a range");
            Console.Write("Enter start of range: ");
            if (int.TryParse(Console.ReadLine(), out int start))
            {
                Console.Write("Enter end of range: ");
                if (int.TryParse(Console.ReadLine(), out int end))
                {
                    Console.Write("Prime numbers: ");
                    for (int i = start; i <= end; i++)
                    {
                        bool isPrime = true;
                        if (i <= 1) continue;

                        for (int j = 2; j <= Math.Sqrt(i); j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                            Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
                else Console.WriteLine("Invalid end value!");
            }
            else Console.WriteLine("Invalid start value!");
            Console.WriteLine();
            #endregion

            #region Q9 - Decimal to Binary
            Console.WriteLine("Q9 - Convert Decimal to Binary");
            Console.Write("Enter a decimal number: ");
            if (int.TryParse(Console.ReadLine(), out int dec))
            {
                string binary = "";
                while (dec > 0)
                {
                    binary = (dec % 2) + binary;
                    dec /= 2;
                }
                Console.WriteLine("Binary: " + binary);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
            Console.WriteLine();
            #endregion

            #region Q10 
            Console.WriteLine("Q10 - Are three points on the same line?");
            Console.Write("Enter x1 y1: ");
            if (double.TryParse(Console.ReadLine(), out double x1) &&
                double.TryParse(Console.ReadLine(), out double y1) &&
                double.TryParse(Console.ReadLine(), out double x2) &&
                double.TryParse(Console.ReadLine(), out double y2) &&
                double.TryParse(Console.ReadLine(), out double x3) &&
                double.TryParse(Console.ReadLine(), out double y3))
            {
                string slope1, slope2;

                if (x2 - x1 == 0)
                    slope1 = "infinite";
                else
                    slope1 = ((y2 - y1) / (x2 - x1)).ToString();

                if (x3 - x2 == 0)
                    slope2 = "infinite";
                else
                    slope2 = ((y3 - y2) / (x3 - x2)).ToString();

                if (slope1 == slope2)
                    Console.WriteLine("The points lie on a straight line.");
                else
                    Console.WriteLine("The points do NOT lie on a straight line.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            Console.WriteLine();
            #endregion

            #region Q11 
            Console.WriteLine("Q11 - Print Identity Matrix");
            Console.Write("Enter size of matrix (n): ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write((i == j ? "1 " : "0 "));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine();
            #endregion
        }
    }
}

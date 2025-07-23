using System;

namespace Assignments.Session6
{
    class Person
    {
        public string Name;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 : Difference Between Passing Value Type Parameters by Value and by Reference
            //By Value: A copy of the value is passed. Changes inside the method do not affect the original variable
            //By Reference(ref): The original variable is passed.Changes inside the method do affect the original variable

            int a = 10;
            ModifyByValue(a);
            Console.WriteLine("After ModifyByValue: " + a); // Output: 10

            ModifyByRef(ref a);
            Console.WriteLine("After ModifyByRef: " + a); // Output: 100
            #endregion


            // By Value: The reference itself is copied, but both still point to the same object.Modifying object content is possible, but reassigning the object won't affect the original
            //By Reference(ref): You can modify the object and reassign it too
            #region q2
            Person person = new Person();
            person.Name = "Ahmed";

            ChangeObject(person);
            Console.WriteLine("After ChangeObject: " + person.Name); // Output: Ali

            ChangeObjectRef(ref person);
            Console.WriteLine("After ChangeObjectRef: " + person.Name); // Output: Omar 
            #endregion

            #region q3
            Console.Write("Enter first number: ");
            bool number1 = int.TryParse(Console.ReadLine(), out int x);

            Console.Write("Enter second number: ");
            bool number2 = int.TryParse(Console.ReadLine(), out int y);

            if (number1 && number2)
            {
                int sum, subtract;
                SumAndSubtract(x, y, out sum, out subtract);
                Console.WriteLine($"Sum = {sum}, Subtraction = {subtract}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter valid integers not anything else");
            }
            #endregion

            #region q4
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int result = SumDigits(number);
                Console.WriteLine($"The sum of the digits of the number {number} is: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            #endregion

            #region q5
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine(IsPrime(n) ? "Prime" : "Not Prime");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            #endregion

            #region q6
            int[] numbers = { 5, 2, 9, 1, 7 };
            int min = 0, max = 0;
            MinMaxArray(numbers, ref min, ref max);
            Console.WriteLine($"Min: {min}, Max: {max}"); 
            #endregion


            #region q7
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num >= 0)
            {
                Console.WriteLine($"Factorial of {num} = {Factorial(num)}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
            #endregion

            #region q8
            string original = "Mohamed";
            string modified = ChangeChar(original, 1, 'a'); // Mohamed
            Console.WriteLine("Modified string: " + modified); 
            #endregion


        }

        #region fucntions
        #region Q1
        /// <summary>
        /// function to ModifyByValue
        /// </summary>
        /// <param name="x"></param>

        static void ModifyByValue(int x)
        {
            x = 100;
        }

        /// <summary>
        /// function to ModifyByRef
        /// </summary>
        /// <param name="x"></param>
        static void ModifyByRef(ref int x)
        {
            x = 100;
        }
        #endregion

        #region q2
        static void ChangeObject(Person p)
        {
            p.Name = "Ali"; // Changes original object
            p = new Person(); // New object assigned locally
            p.Name = "Omar"; // This change won't reflect outside
        }

        static void ChangeObjectRef(ref Person p)
        {
            p = new Person(); // New object assigned outside as well
            p.Name = "Omar";
        }
        #endregion

        #region q3
        static void SumAndSubtract(int a, int b, out int sum, out int subtract)
        {
            sum = a + b;
            subtract = a - b;
        }

        #endregion

        #region q4
        static int SumDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        #endregion

        #region q5
        static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        #endregion

        #region q6
        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = max = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        } 
        #endregion

        #region q7
        static int Factorial(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }
        #endregion

        #region q8
        static string ChangeChar(string input, int position, char newChar)
        {
            if (position < 0 || position >= input.Length)
                return input;

            char[] chars = input.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        } 
        #endregion

        #endregion

    }
}

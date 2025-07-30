using System.Drawing;

namespace Assignments.OOP.Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            Person[] people1 = new Person[3];

            people1[0].Name = "Mohamed";
            people1[0].Age = 23;

            people1[1].Name = "Ahmed";
            people1[1].Age = 26;

            people1[2].Name = "Adel";
            people1[2].Age = 29;

            Console.WriteLine("People Details:");
            foreach (var person in people1)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            #endregion

            #region q2
            Point p1, p2;

            Console.Write("Enter X1: ");
            p1.X = double.Parse(Console.ReadLine());
            Console.Write("Enter Y1: ");
            p1.Y = double.Parse(Console.ReadLine());

            Console.Write("Enter X2: ");
            p2.X = double.Parse(Console.ReadLine());
            Console.Write("Enter Y2: ");
            p2.Y = double.Parse(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            Console.WriteLine($"Distance between points: {distance:F2}");
            #endregion

            #region q3
            Person[] people = new Person[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name of person {i + 1}: ");
                people[i].Name = Console.ReadLine();

                Console.Write($"Enter age of person {i + 1}: ");
                string? input = Console.ReadLine();
                int age;

                while (!int.TryParse(input, out age))
                {
                    Console.Write("Invalid number and Please enter a valid age: ");
                    input = Console.ReadLine();
                }

                people[i].Age = age;
            }

            Person oldest = people[0];
            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].Age > oldest.Age)
                    oldest = people[i];
            }

            Console.WriteLine($"oldest Person: {oldest.Name} and oldeset Age: {oldest.Age}");
            #endregion

            #region q4

            Rectangle rect = new Rectangle();

            Console.Write("Enter width: ");
            rect.Width = double.Parse(Console.ReadLine());

            Console.Write("Enter height: ");
            rect.Height = double.Parse(Console.ReadLine());

            rect.DisplayInfo();

            #endregion


        }

        struct Person
        {
            public string Name;
            public int Age;
        }

        struct Point
        {
            public double X;
            public double Y;
        }

        struct Rectangle
        {
            private double width;
            private double height;

            public double Width
            {
                get { return width; }
                set
                {
                    if (value >= 0)
                        width = value;
                    else
                        Console.WriteLine("Width cannot be negative.");
                }
            }

            public double Height
            {
                get { return height; }
                set
                {
                    if (value >= 0)
                        height = value;
                    else
                        Console.WriteLine("Height cannot be negative.");
                }
            }

            public double Area
            {
                get { return width * height; }
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Width: {width}, Height: {height}, Area: {Area}");
            }
        }
    }
}

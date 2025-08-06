namespace Assignments.OOP.Session4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 - Q1: Calculator Add Overloads
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(1, 2));
            Console.WriteLine(calc.Add(1, 2, 3));
            Console.WriteLine(calc.Add(1.5, 2.5));
            #endregion

            #region Part01 - Q2: Rectangle Constructors
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle(5, 10);
            Rectangle r3 = new Rectangle(7);
            Console.WriteLine($"r1: {r1.Width}, {r1.Height}");
            Console.WriteLine($"r2: {r2.Width}, {r2.Height}");
            Console.WriteLine($"r3: {r3.Width}, {r3.Height}");
            #endregion

            #region Part01 - Q3: Complex Number with Operator Overloading
            ComplexNumber c1 = new ComplexNumber(1, 2);
            ComplexNumber c2 = new ComplexNumber(3, 4);
            ComplexNumber cAdd = c1 + c2;
            ComplexNumber cSub = c1 - c2;
            Console.WriteLine($"Add: {cAdd}");
            Console.WriteLine($"Sub: {cSub}");
            #endregion

            #region Part01 - Q4: Employee/Manager with Override and base
            Manager mgr = new Manager();
            mgr.Work();
            #endregion

            #region Part01 - Q5: Virtual vs new methods
            BaseClass baseObj = new BaseClass();
            DerivedClass1 d1 = new DerivedClass1();
            DerivedClass2 d2 = new DerivedClass2();
            BaseClass b1 = d1;
            BaseClass b2 = d2;

            baseObj.DisplayMessage(); // Base
            d1.DisplayMessage();      // Overridden
            d2.DisplayMessage();      // Hidden
            b1.DisplayMessage();      // Overridden via base
            b2.DisplayMessage();      // Base version due to hiding
            #endregion

            #region Part02: Duration Class
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            D1 = new Duration(3600);
            Console.WriteLine(D1);

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2);

            Duration D3 = new Duration(666);
            Console.WriteLine(D3);

            D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3);

            D3 = --D2;
            Console.WriteLine(D3);

            D1 = D1 - D2;
            Console.WriteLine(D1);

            Console.WriteLine(D1 > D2);
            Console.WriteLine(D1 <= D2);
            Console.WriteLine(D1 ? "True" : "False");

            DateTime dateTime = (DateTime)D1;
            Console.WriteLine(dateTime);
            #endregion
        }
    }

    #region Q1 Calculator
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;
        public double Add(double a, double b) => a + b;
    }
    #endregion

    #region Q2 Rectangle
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int size)
        {
            Width = Height = size;
        }
    }
    #endregion

    #region Q3 Complex Number
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
            => new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);

        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
            => new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);

        public override string ToString() => $"{Real} + {Imaginary}i";
    }
    #endregion

    #region Q4 Employee/Manager
    public class Employee
    {
        public virtual void Work() => Console.WriteLine("Employee is working");
    }

    public class Manager : Employee
    {
        public override void Work()
        {
            base.Work();
            Console.WriteLine("Manager is managing");
        }
    }
    #endregion

    #region Q5 Inheritance Binding
    public class BaseClass
    {
        public virtual void DisplayMessage() => Console.WriteLine("Message from BaseClass");
    }

    public class DerivedClass1 : BaseClass
    {
        public override void DisplayMessage() => Console.WriteLine("Message from DerivedClass1");
    }

    public class DerivedClass2 : BaseClass
    {
        public new void DisplayMessage() => Console.WriteLine("Message from DerivedClass2");
    }
    #endregion

    #region Part02 - Duration
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }

        public override string ToString()
        {
            string result = "";
            if (Hours > 0) result += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0) result += $"Minutes: {Minutes}, ";
            result += $"Seconds: {Seconds}";
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Duration d && Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
        }

        public override int GetHashCode() => HashCode.Combine(Hours, Minutes, Seconds);

        public static Duration operator +(Duration a, Duration b)
        {
            int total = a.ToSeconds() + b.ToSeconds();
            return new Duration(total);
        }

        public static Duration operator +(Duration a, int seconds) => new Duration(a.ToSeconds() + seconds);
        public static Duration operator +(int seconds, Duration a) => new Duration(a.ToSeconds() + seconds);

        public static Duration operator -(Duration a, Duration b) => new Duration(a.ToSeconds() - b.ToSeconds());

        public static Duration operator ++(Duration a) => new Duration(a.ToSeconds() + 60);
        public static Duration operator --(Duration a) => new Duration(a.ToSeconds() - 60);

        public static bool operator >(Duration a, Duration b) => a.ToSeconds() > b.ToSeconds();
        public static bool operator <(Duration a, Duration b) => a.ToSeconds() < b.ToSeconds();
        public static bool operator >=(Duration a, Duration b) => a.ToSeconds() >= b.ToSeconds();
        public static bool operator <=(Duration a, Duration b) => a.ToSeconds() <= b.ToSeconds();

        public static bool operator true(Duration a) => a.ToSeconds() != 0;
        public static bool operator false(Duration a) => a.ToSeconds() == 0;

        public static explicit operator DateTime(Duration a) => DateTime.Today.AddHours(a.Hours).AddMinutes(a.Minutes).AddSeconds(a.Seconds);

        private int ToSeconds() => Hours * 3600 + Minutes * 60 + Seconds;
    }
    #endregion
}
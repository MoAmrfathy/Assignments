using System;
using System.Globalization;

namespace Assignments.OOP.Session3
{
    #region Q1 - Enums for Gender and SecurityLevel
    public enum Gender
    {
        M,
        F
    }

    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }
    #endregion

    #region Q2 - HireDate Class
    public class HireDate : IComparable<HireDate>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public int CompareTo(HireDate other)
        {
            if (Year != other.Year) return Year.CompareTo(other.Year);
            if (Month != other.Month) return Month.CompareTo(other.Month);
            return Day.CompareTo(other.Day);
        }

        public override string ToString() => $"{Day:D2}/{Month:D2}/{Year}";
    }
    #endregion

    #region Q1 & Q3 - Employee Class with Properties, Validation, ToString
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }

        public Employee(int id, string name, Gender gender, SecurityLevel level, decimal salary, HireDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            SecurityLevel = level;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Level: {SecurityLevel}, Salary: {string.Format(CultureInfo.CurrentCulture, "{0:C}", Salary)}, HireDate: {HireDate}";
        }
    }
    #endregion

    #region Q5 - Library Management System (Inheritance)
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }

    public class EBook : Book
    {
        public double FileSize { get; set; }

        public EBook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)
        {
            FileSize = fileSize;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"FileSize: {FileSize} MB");
        }
    }

    public class PrintedBook : Book
    {
        public int PageCount { get; set; }

        public PrintedBook(string title, string author, string isbn, int pageCount)
            : base(title, author, isbn)
        {
            PageCount = pageCount;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Pages: {PageCount}");
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q3 - Create Employee Array
            Employee[] EmpArr = new Employee[3]
            {
                new Employee(1, "Ahmed", Gender.M, SecurityLevel.DBA, 15000, new HireDate(10, 5, 2020)),
                new Employee(2, "Sara", Gender.F, SecurityLevel.Guest, 8000, new HireDate(12, 3, 2023)),
                new Employee(3, "Mostafa", Gender.M, SecurityLevel.SecurityOfficer, 20000, new HireDate(8, 1, 2018))
            };

            Console.WriteLine("=== Before Sorting ===");
            foreach (var emp in EmpArr)
                Console.WriteLine(emp);
            #endregion

            #region Q4 - Sort Employees by Hire Date
            Array.Sort(EmpArr, (e1, e2) => e1.HireDate.CompareTo(e2.HireDate));

            Console.WriteLine("\n=== After Sorting by HireDate ===");
            foreach (var emp in EmpArr)
                Console.WriteLine(emp);

            Console.WriteLine("Boxing/Unboxing Count during sorting: 0 (using generics)");
            #endregion

            #region Q5 - Demonstrate Library System
            Console.WriteLine("\n=== Library System Demo ===");
            Book[] books = new Book[]
            {
                new EBook("C# Advanced", "John Smith", "123456789", 5.6),
                new PrintedBook("Intro to OOP", "Jane Doe", "987654321", 300)
            };

            foreach (var book in books)
            {
                book.Display();
                Console.WriteLine();
            }
            #endregion
        }
    }
}

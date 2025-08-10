using System;

namespace Assignments.OOP.Session5
{
    #region Question 01 - Shapes with Interfaces
    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }

    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Circle | Radius: {Radius} | Area: {Area:F2}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape: Rectangle | Width: {Width} | Height: {Height} | Area: {Area:F2}");
        }
    }
    #endregion

    #region Question 02 - Authentication Service
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }

    public class BasicAuthenticationService : IAuthenticationService
    {
        private string storedUsername = "admin";
        private string storedPassword = "1234";
        private string storedRole = "Admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
    #endregion

    #region Question 03 - Notification Services
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[EMAIL] To: {recipient} | Message: {message}");
        }
    }

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[SMS] To: {recipient} | Message: {message}");
        }
    }

    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[PUSH] To: {recipient} | Message: {message}");
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
         

            #region  Question 01
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(4, 6);

            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            Console.WriteLine();
            #endregion

            #region  Question 02
            IAuthenticationService authService = new BasicAuthenticationService();

            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            if (authService.AuthenticateUser(username, password))
            {
                Console.WriteLine("User authenticated successfully!");

                Console.Write("Enter role to check authorization: ");
                string role = Console.ReadLine();

                if (authService.AuthorizeUser(username, role))
                {
                    Console.WriteLine("User is authorized for this role.");
                }
                else
                {
                    Console.WriteLine("User is NOT authorized for this role.");
                }
            }
            else
            {
                Console.WriteLine("Authentication failed.");
            }
            #endregion

            #region  Question 03
            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("user@example.com", "Welcome to our service!");
            smsService.SendNotification("+20123456789", "Your OTP is 123456.");
            pushService.SendNotification("Device123", "You have a new alert!");
            #endregion
        }
    }
}

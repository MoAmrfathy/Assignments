namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());

            Console.WriteLine("Enter coordinates for Point1 (x y z):");
            int.TryParse(Console.ReadLine(), out int x1);
            int.TryParse(Console.ReadLine(), out int y1);
            int.TryParse(Console.ReadLine(), out int z1);
            Point3D P1 = new Point3D(x1, y1, z1);

            Console.WriteLine("Enter coordinates for Point2 (x y z):");
            int.TryParse(Console.ReadLine(), out int x2);
            int.TryParse(Console.ReadLine(), out int y2);
            int.TryParse(Console.ReadLine(), out int z2);
            Point3D P2 = new Point3D(x2, y2, z2);

            Console.WriteLine(P1 == P2 ? "Points are Equal" : "Points are Different");

            Point3D[] points = { P1, P2, new Point3D(3, 7, 2), new Point3D(1, 9, 5) };
            Array.Sort(points);
            Console.WriteLine("Sorted Points:");
            foreach (var pt in points) Console.WriteLine(pt);

            Point3D cloned = (Point3D)P1.Clone();
            Console.WriteLine("Cloned Point: " + cloned);
        }
    }
}

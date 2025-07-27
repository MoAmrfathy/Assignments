namespace Assignments.OOP.Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Days of the Week:");
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion


            #region q2
            Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Season selectedSeason))
            {
                switch (selectedSeason)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season input.");
            }

            #endregion

            #region q3

            Permission myPermissions = Permission.None;

            myPermissions |= Permission.Read;
            myPermissions |= Permission.Write;

            Console.WriteLine("Current Permissions: " + myPermissions);

            myPermissions &= ~Permission.Write;

            Console.WriteLine("After Removing Write: " + myPermissions);

            if (myPermissions.HasFlag(Permission.Read))
            {
                Console.WriteLine("Read permission is granted.");
            }

            if (!myPermissions.HasFlag(Permission.Execute))
            {
                Console.WriteLine("Execute permission is not granted.");
            }
            #endregion


            #region q4
            Console.Write("Enter a color name: ");
            string readinput = Console.ReadLine();

            if (Enum.TryParse(readinput, true, out Colors selectedColor))
            {
                Console.WriteLine($"{selectedColor} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{readinput} is NOT a primary color.");
            }
            #endregion
        }
    }

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }


    [Flags]
    enum Permission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    enum Colors
    {
        Red,
        Green,
        Blue
    }
}
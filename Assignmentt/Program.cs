namespace Assignmentt
{

    enum WeekDays :byte
    {
        Monday,Tuesday, Wednesday, Thursday , Friday, Saturday , Sunday
    }
    enum Season : byte
    {
        Spring =1, Summer, Autumn, Winter  // Spring = 1 because if the user enter invalid value, the tryparse will return 0
    }

    [Flags]
    enum Permissions : byte
    {
        Read = 1, Write = 2 , Delete = 4 , Execute = 8
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 write a C# program that prints out all the days of the week using this enum.
            //WeekDays Weekday;
            //for (int i = 0; i < 7; i++)
            //{
            //    Weekday = (WeekDays)i;
            //    Console.WriteLine(Weekday);
            //}
            #endregion

            #region Q2: Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season

            //Console.Write("Enter the Season: ");
            //Enum.TryParse<Season>(Console.ReadLine(), true, out Season result);
            //if(result == Season.Spring)
            //    Console.WriteLine("From March to May");
            //else if(result == Season.Summer)
            //    Console.WriteLine("From June to August ");
            //else if(result == Season.Autumn)
            //    Console.WriteLine("From September to November ");
            //else if(result == Season.Winter)
            //    Console.WriteLine("From December to February ");
            //else
            //    Console.WriteLine("Enter a Valid Season");


            #endregion


            #region Q3: Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
            //Permissions Permission;
            //Permission = (Permissions)12; // Delete , Execute


            //Permission = Permission | Permissions.Read;   // Add Permission "Read"
            //Console.WriteLine(Permission); // Read , Delete , Execute

            //Permission = Permission & ~(Permissions.Read);   // remove Permission "Read"
            //Console.WriteLine(Permission);


            //bool IsExist = (Permission & Permissions.Read) == Permissions.Read;  // Checking if "Read" exist
            //Console.WriteLine(IsExist);

            #endregion
        }
    }
}

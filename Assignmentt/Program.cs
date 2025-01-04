namespace Assignmentt
{

    enum WeekDays
    {
        Monday,Tuesday, Wednesday, Thursday , Friday, Saturday , Sunday
    }
    enum Season
    {
        Spring =1, Summer, Autumn, Winter  // Spring = 1 because if the user enter invalid value, the tryparse will return 0
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
        }
    }
}

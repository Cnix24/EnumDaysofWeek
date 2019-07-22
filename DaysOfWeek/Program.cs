using System;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week.");
            string input = Console.ReadLine();
            try
            {
                DayOfWeek dayofweek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input);
                Console.WriteLine("The day you have chosen is: " + dayofweek);
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }

            Console.ReadLine();
        }
    }
}

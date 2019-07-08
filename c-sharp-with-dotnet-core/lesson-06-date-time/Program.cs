using System;

namespace lesson_06_date_time
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeRightNow = DateTime.Now;
            Console.WriteLine($"The current date time is {timeRightNow}");
            //now formatting
            Console.WriteLine($"The current hour of day is {DateTime.Now.Hour}");
            Console.WriteLine($"The current minute of the hour of day is {DateTime.Now.Minute}");
        }
    }
}

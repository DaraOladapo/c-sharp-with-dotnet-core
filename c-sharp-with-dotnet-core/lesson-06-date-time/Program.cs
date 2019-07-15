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
            Console.WriteLine($"The current hour of day is {timeRightNow.Hour}");
            Console.WriteLine($"The current minute of the hour of day is {timeRightNow.Minute}");
            Console.WriteLine($"The current second of the hour and minute of day is {timeRightNow.Second}");

            //ToString()
            Console.WriteLine("Date in Long and Short string");
            Console.WriteLine($"{timeRightNow.ToLongDateString()}");
            Console.WriteLine($"{timeRightNow.ToShortDateString()}");

            Console.WriteLine("Time in Long and Short string");
            Console.WriteLine($"{timeRightNow.ToLongTimeString()}");
            Console.WriteLine($"{timeRightNow.ToShortTimeString()}");

            //more play with date time
            Console.WriteLine($"The time in 5 minutes time is {timeRightNow.AddMinutes(5)}");
            Console.WriteLine($"The time in 5 hours time is {timeRightNow.AddHours(5)}");
            Console.WriteLine($"The time in 5 days time is {timeRightNow.AddDays(5)}");

        }
    }
}

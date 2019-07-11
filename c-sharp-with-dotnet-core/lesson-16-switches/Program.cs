using System;

namespace lesson_16_switches
{
    class Program
    {
        static void Main(string[] args)
        {
            string DayCode="";
           var DayToDay=DateTime.Now.DayOfWeek;
            switch (DayToDay)
            {
                case DayOfWeek.Sunday:
                DayCode="Sabbath Day";
                    break;
                case DayOfWeek.Monday:
                DayCode="Man Crush Monday";
                    break;
                case DayOfWeek.Tuesday:
                DayCode="Turnup Tuesday";
                    break;
                case DayOfWeek.Wednesday:
                DayCode="Woman Crush Wednesday";
                    break;
                case DayOfWeek.Thursday:
                DayCode="Throwback Thursday";
                    break;
                case DayOfWeek.Friday:
                DayCode="Flashback Friday";
                    break;
                case DayOfWeek.Saturday:
                DayCode="Owambe";
                    break;
                default:
                DayCode="Just another day";
                    break;
            }
            System.Console.WriteLine(DayCode);
        }
    }
        enum DaysOfWeek
        {
         Sunday=1,
         Monday,
         Tuesday,
         Wednesday,
         Thursday,
         Friday,
         Saturday
        }
    
}

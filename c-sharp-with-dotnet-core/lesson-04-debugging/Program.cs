using System;

namespace lesson_04_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstVal = 23, secondVal = 19;
            int valDivision = firstVal / secondVal;
            Console.WriteLine($"{firstVal} / {secondVal} = {valDivision}");
            //problem?

            //one way to solve this
            var valDebugDiv = Convert.ToDouble(firstVal) /Convert.ToDouble(secondVal);
            Console.WriteLine($"{firstVal} / {secondVal} = {valDebugDiv}");

            //touch on parsing values and .ToSTring()
            Console.WriteLine($"{Convert.ToInt32("32").GetType()}");
            Console.WriteLine($"{Convert.ToDouble("32").GetType()}");
            Console.WriteLine($"{Convert.ToString(32.44).GetType()}");
            Console.WriteLine($"{valDebugDiv.ToString()} is of type {valDebugDiv.ToString().GetType()} while {valDebugDiv} is of type {valDebugDiv.GetType()}");
        }
    }
}

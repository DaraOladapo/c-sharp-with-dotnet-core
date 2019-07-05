using System;

namespace lesson_03_variables_and_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicit declaration
            int explicitInt;
            explicitInt = 12;
            int anotherExplicitInt = 5;
            Console.WriteLine(explicitInt);
            Console.WriteLine(anotherExplicitInt);
            //implicit declaration
            var implicitVariable = 25;
            Console.WriteLine($"{implicitVariable} is of datatype {implicitVariable.GetType()}");
        }
    }
}

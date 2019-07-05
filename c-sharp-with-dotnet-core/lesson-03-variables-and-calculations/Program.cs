using System;

namespace lesson_03_variables_and_calculations
{
    class Program
    {
        public Program()
        {

        }
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

            //calculations
            int firstVal = 23, secondVal = 19;
            int valAddition = firstVal + secondVal;
            Console.WriteLine($"{firstVal} + {secondVal} = {valAddition}");
            int valSubtraction = firstVal - secondVal;
            Console.WriteLine($"{firstVal} - {secondVal} = {valSubtraction}");
            int valMultiplication = firstVal * secondVal;
            Console.WriteLine($"{firstVal} * {secondVal} = {valMultiplication}");
            //intentional for next lesson
            int valDivision = firstVal / secondVal;
            Console.WriteLine($"{firstVal} / {secondVal} = {valDivision}");

            int valRemainderAfterDiv = firstVal % secondVal;
            Console.WriteLine($"{firstVal} remainder div of {secondVal} = {valRemainderAfterDiv}");
        }
    }
}

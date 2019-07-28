using System;

namespace lesson_02_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            I am a multinline comment
             */
            //basic data types
            //int
            int someInt = 1;
            Console.WriteLine($"{someInt} is of datatype {someInt.GetType()}");
            Console.WriteLine($"Data type INT has a min value of {int.MinValue} and max value of {int.MaxValue}");
            //long
            long someLong = 34232434342;
            Console.WriteLine($"{someLong} is of datatype {someLong.GetType()}");
            Console.WriteLine($"Data type LONG has a min value of {long.MinValue} and max value of {long.MaxValue}");
            //double
            double someDouble = 2.5;
            Console.WriteLine($"{someDouble} is of datatype {someDouble.GetType()}");
            double someOtherDouble = 2;
            Console.WriteLine($"{someOtherDouble} is of datatype {someOtherDouble.GetType()}");
            Console.WriteLine($"Data type DOUBLE has a min value of {double.MinValue} and max value of {double.MaxValue}");
            //float
            float someFloat = 2.0F;
            Console.WriteLine($"{someFloat} is of datatype {someFloat.GetType()}");
            //string
            string someString = "I am a string";
            Console.WriteLine($"{someString} is of datatype {someString.GetType()}");
            //char
            char someChar = 'c';
            Console.WriteLine($"{someChar} is of datatype {someChar.GetType()}");
        }
    }
}
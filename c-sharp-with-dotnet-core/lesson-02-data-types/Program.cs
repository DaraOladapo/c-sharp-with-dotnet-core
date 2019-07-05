using System;

namespace lesson_02_data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic data types
            //int
            int someInt=1;
            Console.WriteLine($"{someInt} is of datatype {someInt.GetType()}");
            //long
            long someLong = 34232434342;
            Console.WriteLine($"{someLong} is of datatype {someLong.GetType()}");
            //double
            double someDouble=2.5;
            Console.WriteLine($"{someDouble} is of datatype {someDouble.GetType()}");
            double someOtherDouble=2;
            Console.WriteLine($"{someOtherDouble} is of datatype {someOtherDouble.GetType()}");
            //float
            float someFloat=2.0F;
            Console.WriteLine($"{someFloat} is of datatype {someFloat.GetType()}");
            //string
            string someString="I am a string";
            Console.WriteLine($"{someString} is of datatype {someString.GetType()}");
            //char
            char someChar='c';
            Console.WriteLine($"{someChar} is of datatype {someChar.GetType()}");
        }
    }
}
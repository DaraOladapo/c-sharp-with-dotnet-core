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
            Console.WriteLine($"{someInt} is an {someInt.GetType()}");
            //double
            double someDouble=2.5;
            Console.WriteLine($"{someDouble} is an {someDouble.GetType()}");
            double someOtherDouble=2;
            Console.WriteLine($"{someOtherDouble} is an {someOtherDouble.GetType()}");
            //float
            float someFloat=2.0F;
            Console.WriteLine($"{someFloat} is an {someFloat.GetType()}");
            //string
            string someString="I am a string";
            Console.WriteLine($"{someString} is an {someString.GetType()}");
            //char
            char someChar='c';
            Console.WriteLine($"{someChar} is an {someChar.GetType()}");
        }
    }
}

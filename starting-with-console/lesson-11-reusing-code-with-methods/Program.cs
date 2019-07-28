using System;

namespace lesson_11_reusing_code_with_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //accept input
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            //perform calculation
            var AdditionResult=Add(a,b);
            System.Console.WriteLine(AdditionResult);
            var SubstractionResult=Subtract(a,b);
            Console.WriteLine(SubstractionResult);
        }
        static int Add(int a, int b)
        {
            return a+b;
        }
        static int Subtract(int a,int b)
        {
            if(a>b)
            {
                return a-b;
            }
            else
            {
                return b-a;
            }
        }
    }
}

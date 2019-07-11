using System;

namespace lesson_12_handling_errors
{
    class Program
    {
        static void Main(string[] args)
        {
            //accept inputs
            var input1=Console.ReadLine();
            var input2=Console.ReadLine();

            //decide on inputs
            int a,b;
            Console.WriteLine("Enter Values");
            bool inputAIsInt=int.TryParse(input1,out a);
            bool inputBIsInt=int.TryParse(input2,out b);
            if(inputAIsInt=true && inputBIsInt==true){
                var AdditionResult=Add(a,b);
                var SubtractionResult=Subtract(a,b);
                Console.WriteLine($"{a} + {b} = {AdditionResult}");
                Console.WriteLine($"{a} - {b} = {SubtractionResult}");
            }
            else
            {
                Console.WriteLine("You entered some really bad input, be a good fella and try again nex time");
            }
           
            //perform calculation
            // var AdditionResult=Add(a,b);
            // Console.WriteLine(AdditionResult);
            // var SubstractionResult=Subtract(a,b);
            // Console.WriteLine(SubstractionResult);
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

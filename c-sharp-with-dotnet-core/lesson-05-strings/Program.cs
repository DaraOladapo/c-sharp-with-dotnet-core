using System;

namespace lesson_05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //playing with strings
            string someString = "I'm string";
            Console.WriteLine(someString);

            //escape sequence
            string someOtherString = "\nI'm starting after a new line" +
                "\tand I am after a tab." +
                "\\ -I'm a single slash but you see in code I have double of that.";
            Console.WriteLine(someOtherString);

            //string manipulations
            string firstSegment = "I should form", secondSegment = "a complete sentence";
            //direct concatenation
            Console.WriteLine(firstSegment + " " + secondSegment);
            //placeholdeer concatenation
            Console.WriteLine("{0} {1}", firstSegment, secondSegment);
            //template string
            Console.WriteLine($"{firstSegment} {secondSegment}");
        }
    }
}

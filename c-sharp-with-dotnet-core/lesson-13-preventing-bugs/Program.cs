using System;

namespace lesson_13_preventing_bugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                a=int.Parse(Console.ReadLine());
                System.Console.WriteLine($"Your input was {a}");
            }
            catch (System.Exception exception)
            {
             System.Console.WriteLine($"An error occured.\nMessage: {exception.Message}");
             //System.Console.WriteLine($"Follow this link - {exception.HelpLink} - to learn more");  
            }
            // finally
            // {
            // System.Console.WriteLine("This finally happened");
            // }
        }
    }
}

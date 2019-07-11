using System;

namespace lesson_09_making_choices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the weight of the child born?");
            double newBornWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the gender? 1 for male, 2 for female");
            int newBornGender = int.Parse(Console.ReadLine());
            WeightClass weightClass;
            if (newBornWeight < 1.0)
            {
                weightClass = WeightClass.UnderWeight;
            }
            else if (newBornWeight >= 1.0 && newBornWeight <= 2.0)
            {
                weightClass = WeightClass.Normal;
            }
            else
            {
                weightClass = WeightClass.Overweight;
            }
            Child newBorn = new Child
            {
                Weight = newBornWeight,
                Gender = (Gender)newBornGender,
                WeightClass = weightClass
            };
            Console.WriteLine($"A {newBorn.Gender} child was born and weighs {newBorn.Weight}kg and is {newBorn.WeightClass}");

            //ternary operator
            int userAge = 12; //assume this is an input
                              //    if (userAge<13){
                              //        System.Console.WriteLine("Underage to use app");
                              //    }
                              //    else
                              //    {
                              //     System.Console.WriteLine("Allowed to use app");   
                              //    }
            var Response = userAge < 13 ? "Underage to use app" : "Allowed to use app";
            System.Console.WriteLine(Response);

            //nesting
            int age=14;
            if(age<18){
                if(age<13){
                    System.Console.WriteLine("Children Class");
                }
                else
                {
                    System.Console.WriteLine("Teenagers Class");
                }
            }
            else
            {
                System.Console.WriteLine("Adult Class");
            }
        }
    }
    enum WeightClass
    {
        UnderWeight,
        Normal,
        Overweight
    }
    struct Child
    {
        public double Weight;
        public Gender Gender;
        public WeightClass WeightClass;
    }
    enum Gender
    {
        Male = 1,
        Female
    }
}

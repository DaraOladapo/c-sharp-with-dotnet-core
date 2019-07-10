using System;

namespace lesson_09_making_choices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the weight of the child born?");
            double newBornWeight=double.Parse(Console.ReadLine());
            Console.WriteLine("What is the gender? 1 for male, 2 for female");
            int newBornGender=int.Parse(Console.ReadLine());
            WeightClass weightClass;
            if (newBornWeight<1.0)
            {
                weightClass=WeightClass.UnderWeight;
            }
            else if(newBornWeight >= 1.0 && newBornWeight <= 2.0 )
            {
             weightClass=WeightClass.Normal;
            }
            else
            {
                weightClass=WeightClass.Overweight;
            }
            Child newBorn=new Child
            {
                Weight=newBornWeight,
                Gender=(Gender)newBornGender,
                WeightClass=weightClass
            };
 Console.WriteLine($"A {newBorn.Gender} child was born and weighs {newBorn.Weight}kg and is {newBorn.WeightClass}");
       
        }
    }
    enum WeightClass{
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
     Male=1,
     Female
    }
}

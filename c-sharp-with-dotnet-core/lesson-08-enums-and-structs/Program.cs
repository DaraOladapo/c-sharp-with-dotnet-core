using System;

namespace lesson_08_enums_and_structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //enums
            // Console.WriteLine("Kindly rate your banking experience where 1 is Very Dissatisfied and 5 is Very Satisfied");
            // var customerRatingInput=int.Parse(Console.ReadLine());
            // var customerRating=(Rating)customerRatingInput;
            // Console.WriteLine(customerRating);
            Console.WriteLine("What is the weight of the child born?");
            double newBornWeight=double.Parse(Console.ReadLine());
            Console.WriteLine("What is the gender? 1 for male, 2 for female");
            int newBornGender=int.Parse(Console.ReadLine());
            Child newBorn=new Child
            {
                Weight=newBornWeight,
                Gender=(Gender)newBornGender
            };
            Console.WriteLine($"A {newBorn.Gender} child was born and weighs {newBorn.Weight}kg");
        }
    }

    struct Child
    {
        public double Weight;
        public Gender Gender;
    }
    enum Gender
    {
     Male=1,
     Female
    }
   enum Rating
    {
     VeryDissatisfied=1,
     Dissatisfied,
     Indifferent,
    Satisfied,
    VerySatisfied
    
    }
}

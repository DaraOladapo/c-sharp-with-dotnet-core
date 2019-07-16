using System;
using System.Collections.Generic;

namespace lesson_14_defining_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle myCirle = new Circle()
            // {
            //     Diameter = 2.4
            // };
            // Console.WriteLine(myCirle.Area);
            //Lets cook some food
            Food RiceMeal = new Food();
            List<Ingredient> Ingredients = new List<Ingredient>();
            //assumed input
            RiceMeal.Name = "White Rice";
            Ingredients.Add(new Ingredient() { Name = "Water", Quantity = 2, Unit = MeasureUnit.Cup });
            Ingredients.Add(new Ingredient() { Name = "Rice", Quantity = 3, Unit = MeasureUnit.DeRica });
            Ingredients.Add(new Ingredient() { Name = "Salt", Quantity = 3, Unit = MeasureUnit.Pinch });
            RiceMeal.Ingredients = Ingredients;

            Console.WriteLine($"We are about to cook {RiceMeal.Name} and below are the list of ingredients.");
            foreach (var Ingredient in RiceMeal.Ingredients)
            {
                Console.WriteLine($"{Ingredient.Quantity} {Ingredient.Unit.ToString().ToLower()} of {Ingredient.Name}");
            }
            Console.WriteLine("Enjoy cooking!");
        }
    }
}

using System;
using System.Collections.Generic;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what do you want to cook? (1 for Rice, 2 for Beans, 3 for Amala)");
            int foodInt = int.Parse(Console.ReadLine());
            Food foodSelected = (Food) foodInt;
            Console.WriteLine($"Okay, you want to cook {foodSelected}. Cooool.");

            Console.WriteLine("Do you want to add an ingredient. (Y for yes and N for no)");
            string reply = Console.ReadLine().ToUpper();
            bool replyBool = reply == "Y" ? true : false;
            List<Ingredient> Ingredients = new List<Ingredient>();
            while(replyBool){
                Ingredient Ingredient = new Ingredient();
                Console.WriteLine("Enter the name of the ingredient: ");
                string IngredientName = Console.ReadLine();
                Ingredient.name = IngredientName;

                Console.WriteLine("Enter the quantity: ");
                double IngredientQuantity = double.Parse(Console.ReadLine());
                Ingredient.quantity = IngredientQuantity;

                Console.WriteLine("Enter the units: (1 for ounce, 2 for kg, 3 for pinch, 4 for cup and 5 for litre");
                MeasuringUnits unit = (MeasuringUnits)int.Parse(Console.ReadLine());
                Ingredient.unit = unit;

                Ingredients.Add(Ingredient);

                Console.WriteLine("Do you want to add more? (Y for yes and N for no)");
                reply = Console.ReadLine().ToUpper();
                replyBool = reply == "Y" ? true : false;
            }
            foreach (var Ingredient in Ingredients)
            {
                System.Console.WriteLine($"{Ingredient.quantity} {Ingredient.unit} of {Ingredient.name}");
            }
            Console.WriteLine("Hope it taste nice?");
        }
    }
}

using System;
using System.Collections.Generic;

namespace lesson_15_initializing_objects
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("We're about to cook. Why don't you go ahead and give use the name of the food?");
        var InputFoodName=Console.ReadLine();
        Console.WriteLine("How many ingredients are you using?");
        var IngredientCount=int.Parse(Console.ReadLine());
        List<Ingredient> Ingredients=new List<Ingredient>();
        for (int i = 1; i <= IngredientCount;i++)
        {
        Console.WriteLine($"Ingredient Name {i}?");
         var InputName=Console.ReadLine();   
        Console.WriteLine("Quantity");
         var InputQuantity=Console.ReadLine();
        Console.WriteLine("Unit?");
        Console.WriteLine("1 for g, 2 for kg, 3 for ounce, 4 for cup, 5 for spoonful, 6 for kongo, 7 for derica, 8 for pinch, 9 for satchet, 10 for litre");
         var InputUnit=(MeasureUnit)int.Parse(Console.ReadLine());
         Ingredients.Add(
                 new Ingredient()
                 {
                     Name=InputName,
                     Quantity=double.Parse(InputQuantity),
                     Unit=InputUnit
                 }
                 );
        }
        var MealInput=new Food(){
            Name=InputFoodName,
            Ingredients=Ingredients
            };
          
          Console.WriteLine($"We are about to cook {MealInput.Name} and below are the list of ingredients.");
         foreach (var Ingredient in MealInput.Ingredients)
         {
            //  Helpers Helper=new Helpers();
            //  var TriedReturnUnit=Helper.TryPluralize(Ingredient.Quantity, Ingredient.Unit.ToString());
          //var TriedReturnUnit=new Helpers().TryPluralize(Ingredient.Quantity, Ingredient.Unit.ToString());
          //solving some memory problem that may arise
          var TriedReturnUnit=Helpers.TryPluralize(Ingredient.Quantity, Ingredient.Unit.ToString());
          Console.WriteLine($"{Ingredient.Quantity} {TriedReturnUnit} of {Ingredient.Name}");  
         }
         Console.WriteLine("Enjoy cooking!");
        }
    }
}

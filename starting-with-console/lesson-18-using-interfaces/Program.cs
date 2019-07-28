using System;

namespace lesson_18_using_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What is your car name?");
            var CarName = Console.ReadLine();
            System.Console.WriteLine($"What is your {CarName} model?");
            var Model = Console.ReadLine();
            System.Console.WriteLine($"What year was your {CarName} {Model} made?");
            var MakeYear = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"How much fuel you got?");
            var FuelAmount=double.Parse(Console.ReadLine());
            Car MyCar = new Car(CarName, Model, MakeYear, FuelAmount);
            var GottenFuelStatus = MyCar.GetFuelStatus(MyCar.FuelAmount);
            Console.WriteLine($"Our {MyCar.MakeYear} {MyCar.Name} {MyCar.Model} has {GottenFuelStatus} fuel.");
            if (GottenFuelStatus.ToLower() != "Empty".ToLower())
            {
                MyCar.Start();
                MyCar.Accelerate();
                MyCar.Stop();
                MyCar.Reverse();
                MyCar.Stop();
                MyCar.Accelerate();
            }
            else
            {
                Console.WriteLine("Sorry, car fuel tank is empty, so we ain't gonna start it for you");
            }
        }
    }
}

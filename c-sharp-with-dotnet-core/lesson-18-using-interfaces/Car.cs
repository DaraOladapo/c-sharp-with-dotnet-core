using System;
using System.Collections.Generic;

namespace lesson_18_using_interfaces
{
    class Car : Automobile, IAutomobile
    {
        public Car(string Name, string Model, int MakeYear, double FuelAmount)
        {
            this.Name = Name;
            this.Model = Model;
            this.MakeYear = MakeYear;
            this.FuelAmount = FuelAmount;
        }
        public void Accelerate()
        {
            this.FuelAmount -= 2;
            Console.WriteLine($"Current Fuel Amount: {FuelAmount} after accelerating");
        }

        public string GetFuelStatus(double FuelAmount)
        {
            FuelStatus fuelStatus;
            if (FuelAmount == 0)
            {
                fuelStatus = FuelStatus.Empty;
            }
            else if (FuelAmount < 10)
            {
                fuelStatus = FuelStatus.Reserve;
            }
            else if (FuelAmount > 10 && FuelAmount <= 69)
            {
                fuelStatus = FuelStatus.Okay;
            }
            else
            {
                fuelStatus = FuelStatus.Full;
            }
            return fuelStatus.ToString();
        }

        public void Move()
        {
            this.FuelAmount--;
            Console.WriteLine($"Current Fuel Amount: {FuelAmount} litres after moving");
        }

        public void Reverse()
        {
            this.FuelAmount--;
            Console.WriteLine($"Current Fuel Amount: {FuelAmount} litres after reversing");
        }

        public void Start()
        {
            this.FuelAmount-=0.25;
            Console.WriteLine($"Current Fuel Amount: {FuelAmount} litres after starting");
        }

        public void Stop()
        {
            Console.WriteLine($"Our car has stopped. Current fuel status: {this.FuelAmount} litres");
        }
    }
}

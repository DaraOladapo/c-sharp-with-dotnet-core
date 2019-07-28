namespace lesson_18_using_interfaces
{
    interface IAutomobile
    {
        void Move();
        void Start();
        void Stop();
        void Reverse();
        void Accelerate();
        string GetFuelStatus(double FuelAmount);
    }
}

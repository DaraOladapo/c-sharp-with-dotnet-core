using System.Collections.Generic;

namespace lesson_18_using_interfaces
{
    class Automobile
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int MakeYear { get; set; }
        public string Color { get; set; }
        public double FuelAmount { get; set; }
        public List<Part> Parts { get; set; }
    }
}

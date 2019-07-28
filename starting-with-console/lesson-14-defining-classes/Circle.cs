using System;
using System.Collections.Generic;
using System.Text;

namespace lesson_14_defining_classes
{
    class Circle
    {
        double Pi = Math.PI;
        public double Diameter { get; set; }
        public double Area { get { return Pi * Math.Pow((Diameter / 2), 2); } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Core
{
    public class Rectangle
    {
        private double _side1, _side2;

        public double Area { get; private set; }
        public double Perimeter { get; private set; }

        public double Side1
        {
            get => _side1;
            set => _side1 = value;
        }

        public double Side2
        {
            get => _side2;
            set => _side2 = value;
        }

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        public double AreaCalculation()
        {
            Area = Side1 * Side2;

            return Area;
        }

        public double PerimeterCalculation()
        {
            Perimeter = (Side1 + Side2) * 2;
            return Perimeter;
        }
    }
}

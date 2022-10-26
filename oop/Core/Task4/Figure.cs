using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Core.Task4
{
    public class Figure
    {
        public Point _a;
        public Point _b;
        public Point _c;
        public Point _d;
        public Point _e;


        public Figure(Point a, Point b, Point c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public Figure(Point a, Point b, Point c, Point d)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _e = e;
        }

        public double LenghtSide(Point A, Point B)
        {
            return 0;
        }

        public void PerimeterCalculation()
        {

        }
    }
}

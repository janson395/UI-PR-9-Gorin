using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Core.Task4
{
    public class Point
    {
        private int a { get; }
        private int b { get; }
        private string name { get; }

        public Point(int a, int b, string name)
        {
            this.a = a;
            this.b = b;
            this.name = name;
        }
    }
}

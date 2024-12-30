using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Training_04
{
    abstract class Shape
    {
        public abstract double Area();
    }
    class Square : Shape
    {
        private double length;

        public Square(double a)
        {
            length = a;
        }

        public override double Area()
        {
            return (length * length);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Lectures_12
{
    class Circle:Figure
    {
        public override double Area(double side)
        {
            return Math.PI * side * side;
        }
    }
}

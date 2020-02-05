using System;
using System.Collections.Generic;
using System.Text;

namespace Lectures_12
{
    class Figure
    {
        string _name;

        double _side;

        public double Side { get; set; }

        public virtual double Area(double side)
        {
            side = _side;
            return side * side;
        }

        public void Display(string name)
        {
            
        }
    }
}

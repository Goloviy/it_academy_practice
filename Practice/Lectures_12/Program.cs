using System;

namespace Lectures_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Circle circle = new Circle();
            circle.Side = rnd.Next(1, 10);
            
        }
    }
}

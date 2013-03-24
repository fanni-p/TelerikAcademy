using System;

namespace _1.Calculate_Surface
{
    class Triangle:Shape
    {
        public Triangle(double height, double width)
            :base(height,width)
        {
        }

        public override double CalculateSurface()
        {
            return (height * width) / 2;
        }
    }
}

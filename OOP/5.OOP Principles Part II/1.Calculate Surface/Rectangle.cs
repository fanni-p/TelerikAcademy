using System;

namespace _1.Calculate_Surface
{
    class Rectangle:Shape
    {
        public Rectangle(double height, double width)
            :base(height,width)
        {
        }

        public override double CalculateSurface()
        {
            return height*width;
        }
    }
}

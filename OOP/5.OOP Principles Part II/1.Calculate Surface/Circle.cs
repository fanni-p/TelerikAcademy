using System;

namespace _1.Calculate_Surface
{
    class Circle:Shape
    {
        public const double PI = 3.14159265359;

        public Circle(double width)
            :base(width,width)
        {
        }

        public override double CalculateSurface()
        {
            return (PI * height * width) / 4;
        }
    }
}

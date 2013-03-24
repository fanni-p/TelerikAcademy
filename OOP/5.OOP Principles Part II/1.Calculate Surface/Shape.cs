using System;

namespace _1.Calculate_Surface
{
    public abstract class Shape
    {
        public double height;
        public double width;

        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public abstract double CalculateSurface();
    }
}

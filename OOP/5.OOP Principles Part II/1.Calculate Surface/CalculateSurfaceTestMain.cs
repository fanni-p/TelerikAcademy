using System;

namespace _1.Calculate_Surface
{
    class CalculateSurfaceTestMain
    {
        static void Main(string[] args)
        {
            Shape newRectangle = new Rectangle(5, 4);
            Shape newTriangle = new Triangle(3, 2);
            Shape newCircle = new Circle(6);

            Console.WriteLine("Calculate area of rectangle height = {0}, width = {1}", newRectangle.height, newRectangle.width);
            Console.WriteLine("Rectangle area = {0}", newRectangle.CalculateSurface());
            Console.WriteLine(new string('-',50));

            Console.WriteLine("Calculate area of trinagle height = {0}, width = {1}", newTriangle.height, newTriangle.width);
            Console.WriteLine("Triangle area = {0}", newTriangle.CalculateSurface());
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Calculate area of circle diameter = {0}", newCircle.width);
            Console.WriteLine("Circle area = {0:F2}", newCircle.CalculateSurface()); // using formula (pi*d*d)/4
            Console.WriteLine(new string('-', 50));
        }
    }
}

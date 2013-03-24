using System;

namespace _2.Perimeter_and_area_of_a_circle
{
    class PerimeterAndAreaOfACircle
    {
        static void Main()
        {
            Console.Write("Enter the radius of a circle r = ");
            int r = int.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("The perimeter of the circle is {0} and the area is {1}.", perimeter, area);
        }
    }
}

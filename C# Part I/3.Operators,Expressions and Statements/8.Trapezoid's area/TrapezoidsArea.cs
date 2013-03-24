using System;

namespace _8.Trapezoid_s_area
{
    class TrapezoidsArea
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Enter h = ");
            double h = int.Parse(Console.ReadLine());
            double area = ((a + b) / 2) * h;
            if (a > 0 && b > 0 && h > 0)
            {
                Console.WriteLine("The trapezoid's area (a={0}, b={1}, h={2}) is {3}", a, b, h, area);
            }
            else
            {
                Console.WriteLine("Invalid numbers. Please enter positive numbers.");
            }
        }
    }
}

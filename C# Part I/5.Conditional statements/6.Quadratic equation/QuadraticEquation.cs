using System;

namespace _6.Quadratic_equation
{
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c = ");
            double c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            if (a == 0)
            {
                double x = (-b) / c;
                Console.WriteLine("There is exactly one real root x = {0}", x);
            }
            else if (d < 0)
            {
                Console.WriteLine("There are no real roots.");
            }
            else if (d == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("There is exactly one real root x = {0}", x);
            }
            else if (d > 0)
            {
                double x1 = ((-b) + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                double x2 = ((-b) - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine("There are two real roots x1 = {0} and x2 = {1}.", x1, x2);
            }
        }
    }
}


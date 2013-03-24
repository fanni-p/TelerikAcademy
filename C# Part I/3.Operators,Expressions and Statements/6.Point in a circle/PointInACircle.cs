using System;

namespace _6.Point_in_a_circle
{
    class PointInACircle
    {
        static void Main()
        {
            Console.Write("Enter X = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter Y = ");
            int y = int.Parse(Console.ReadLine());
            int R = 5;
            if ((x * x) + (y * y) <= (R * R))
            {
                Console.WriteLine("The point({0},{1}) is in the circle K(0,5)", x, y);
            }
            else
            {
                Console.WriteLine("The point({0},{1}) is not in the circle K(0,5)", x, y);
            }

        }
    }
}

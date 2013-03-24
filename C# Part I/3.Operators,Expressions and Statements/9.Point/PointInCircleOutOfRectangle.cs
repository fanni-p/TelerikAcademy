using System;

namespace _9.Point
{
    class PointInCircleOutOfRectangle
    {
        static void Main()
        {
            Console.Write("Enter X = ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter Y = ");
            double y = double.Parse(Console.ReadLine());
            double R = 3;
            if (((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) > (R * R))
            {
                Console.WriteLine("The point is out of the circle K((1,1),3).");
            }
            else
            {
                if ((x >= -1 && x <= 4) && (y >= -1 && y <= 1))
                {
                    Console.WriteLine("The point is in the circle K((1,1),3) and in the rectangle.");
                }
                else
                {
                    Console.WriteLine("The point is in the circle K((1,1),3) and out of the rectangle.");
                }
            }
        }
    }
}

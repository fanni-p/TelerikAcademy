using System;

namespace _8.Greatest_common_divisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            Console.Write("Enter a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b = ");
            int b = int.Parse(Console.ReadLine());
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("The greatest common divisor is {0}.",b);
            }
            else
            {
                Console.WriteLine("The greatest common divisor is {0}.",a);
            }
        }
    }
}

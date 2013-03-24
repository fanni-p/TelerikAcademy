using System;

namespace _3.Trapezoid
{
    class Trapezoid
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n * 2; i++)
            {
                if (i > n)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            for (int i = n; i > 1; i--)
            {
                for (int j = 1; j <= n*2; j++)
                {
                    if (i == j)
                    {
                        Console.Write("*");
                    }
                    else if (j == n * 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n * 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

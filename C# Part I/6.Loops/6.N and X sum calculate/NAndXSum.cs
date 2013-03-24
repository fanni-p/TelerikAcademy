using System;

namespace _6.N_and_X_sum_calculate
{
    class NAndXSum
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter X = ");
            int x = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            int xn = 1;
            decimal sum = 1;
            if (n > 0 && x >= 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial= factorial*i;
                    xn = xn * x;
                    x = xn;
                    sum = sum + (factorial / xn);
                }
                Console.WriteLine("Sum = 1 + 1!/X + 2!/X^2 + … + N!/X^N = {0}", sum);
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }
        }
    }
}

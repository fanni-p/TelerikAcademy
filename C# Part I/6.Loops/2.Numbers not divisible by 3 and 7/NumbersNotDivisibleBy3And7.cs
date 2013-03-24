using System;

namespace _2.Numbers_not_divisible_by_3_and_7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

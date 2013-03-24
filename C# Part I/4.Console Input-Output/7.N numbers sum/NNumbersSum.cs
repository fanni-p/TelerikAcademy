using System;

namespace _7.N_numbers_sum
{
    class NNumbersSum
    {
        static void Main()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter {0} number: ", i);
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }
            Console.WriteLine("The sum is {0}.", sum);
        }
    }
}


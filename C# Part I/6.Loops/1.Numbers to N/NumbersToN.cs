using System;

namespace _1.Numbers_to_N
{
    class NumbersToN
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;

namespace _13.Trailing_zeros
{
    class TrailingZeros
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            int zeros = 0;
            for (int i = 5; i <= n; i *= i)
            {
                zeros = zeros + (n / i);
            }
            Console.WriteLine("The trailing zeros in {0}! are: {1}",n, zeros);
        }
    }
}

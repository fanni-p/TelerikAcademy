using System;

namespace _7.Prime_number
{
    class PrimeNumber
    {
        static void Main()
        {
            Console.Write("Enter a number between 0 and 100:");
            int n = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(n);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (n % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("The number {0} is prime - {1}", n, prime);
        }
    }
}

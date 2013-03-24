using System;

namespace _5.NK_Factorial
{
    class NKFactorial2
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K = ");
            int k = int.Parse(Console.ReadLine());
            int KN = k-n;
            decimal factorialN = 1;
            decimal factorialK = 1;
            decimal factorialKN = 1;
            if (n >= 1 && k > n)
            {
                while (n >=1)
                {
                    factorialN = factorialN * n;
                    n--;
                }
                while (k >= 1)
                {
                    factorialK = factorialK * k;
                    k--;
                }
                while (KN >= 1)
                {
                    factorialKN = factorialKN * KN;
                    KN--;
                }
                Console.WriteLine("N!*K!/(K-N)! = {0}", (factorialN * factorialK) / factorialKN);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}

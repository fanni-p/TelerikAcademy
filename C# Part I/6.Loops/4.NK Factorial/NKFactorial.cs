using System;

namespace _4.NK_Factorial
{
    class NKFactorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K = ");
            int k = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            if (k > 1 && n > k)
            {
                while (n >= k + 1)
                {
                    factorial = factorial * n;
                    n--;
                }
                Console.WriteLine("N!/K! = {0}", factorial);
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}

using System;

namespace _7.First_N_Fibonacci_members
{
    class FirstNFibonacciMembers
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            decimal fn = 0;
            decimal f1 = 0;
            decimal f2 = 1;
            Console.WriteLine("First {0} members of the sequence of Fibonacci:",n);
            Console.WriteLine("1. {0}\n2. {1}", f1, f2);
            for (int i = 3; i <= n; i++)
            {
                fn = f1 + f2;
                Console.WriteLine("{0}. {1}", i, fn);
                f1 = f2;
                f2 = fn;
            }
        }
    }
}

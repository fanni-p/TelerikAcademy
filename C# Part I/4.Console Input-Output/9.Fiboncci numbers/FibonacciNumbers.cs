using System;

namespace _9.Fiboncci_numbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            decimal fn = 0;
            decimal f1 = 0;
            decimal f2 = 1;
            Console.WriteLine("First 100 members of the sequence of Fibonacci:");
            Console.WriteLine("1. {0}\n2. {1}", f1, f2);
            for (int i = 3; i <= 100; i++)
            {
                fn = f1 + f2;
                Console.WriteLine("{0}. {1}",i,fn);
                f1 = f2;
                f2 = fn;
            }
        }
    }
}

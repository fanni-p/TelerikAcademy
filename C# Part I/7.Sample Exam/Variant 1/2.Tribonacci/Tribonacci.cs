using System;
using System.Numerics;

namespace _2.Tribonacci
{
    class Tribonacci
    {
        static void Main()
        {
            BigInteger t1 = BigInteger.Parse(Console.ReadLine());
            BigInteger t2 = BigInteger.Parse(Console.ReadLine());
            BigInteger t3 = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            BigInteger tn = 0;
            if (n == 1)
            {
                tn = t1;
            }
            else if (n == 2)
            {
                tn = t2;
            }
            else if (n == 3)
            {
                tn = t3;
            }
            for (int i = 4; i <= n; i++)
            {
                tn = t1 + t2 + t3;
                if (i == n)
                {
                    break;
                }
                t1 = t2;
                t2 = t3;
                t3 = tn;
            }
            Console.WriteLine(tn);
        }
    }
}

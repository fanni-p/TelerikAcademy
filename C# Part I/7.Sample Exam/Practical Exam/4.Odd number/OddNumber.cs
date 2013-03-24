using System;
using System.Threading;
using System.Globalization;

namespace _4.Odd_number
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            long[] array = new long[n];
            long result = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = long.Parse(Console.ReadLine());
                result ^= array[i];
            }
            Console.WriteLine(result);
        }
    }
}

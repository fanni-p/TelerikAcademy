using System;

namespace _5.Subset_Sum
{
    class SubsetSum
    {
        static void Main()
        {
            long s = long.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            bool setNonEmpty = false;
            long sum = 0;
            int count = 0;
            long[] numbers = new long[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 0; i < (1 << n); i++)
            {
                sum = 0;
                setNonEmpty = false;

                for (byte j = 0; j < n; j++)
                {
                    if ((i & (1 << j)) != 0)
                    {
                        sum += numbers[j];
                        setNonEmpty = true;
                    }
                }
                if (setNonEmpty && sum == s)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

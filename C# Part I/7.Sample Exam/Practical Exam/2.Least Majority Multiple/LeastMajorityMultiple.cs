using System;

namespace _2.Least_Majority_Multiple
{
    class LeastMajorityMultiple
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int i = 0;
            int count = 0;
            while (count < 3)
            {
                count = 0;
                i++;
                if (i % a == 0)
                {
                    count++;
                }
                if (i % b == 0)
                {
                    count++;
                }
                if (i % c == 0)
                {
                    count++;
                }
                if (i % d == 0)
                {
                    count++;
                }
                if (i % e == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(i);
        }
    }
}

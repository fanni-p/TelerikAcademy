using System;

namespace _10.Sum_0._001
{
    class Sum
    {
        static void Main()
        {
            double sum = 1;
            for (double i = 2; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + (1 / i);
                }
                else
                {
                    sum = sum - (1 / i);
                }
            }
            Console.WriteLine("1 + 1/2 - 1/3 + 1/4 - 1/5...=?");
            Console.WriteLine("The sum is {0:0.000}", sum);
        }
    }
}

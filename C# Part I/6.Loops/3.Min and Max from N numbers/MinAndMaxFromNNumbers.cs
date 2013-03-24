using System;

namespace _3.Min_and_Max_from_N_numbers
{
    class MinAndMaxFromNNumbers
    {
        static void Main()
        {
            Console.Write("Enter N = ");
            int n = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter {0} number: ", i);
                int number = int.Parse(Console.ReadLine());
                if (number < minValue)
                {
                    minValue = number;
                }
                else if (number > maxValue)
                {
                    maxValue = number;
                }
            }
            Console.WriteLine("The MinValue is {0}.", minValue);
            Console.WriteLine("The MaxValue is {0}.", maxValue);
        }
    }
}

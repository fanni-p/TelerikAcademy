using System;

namespace _8.Print_all_numbers
{
    class PrintAllNumbers
    {
        static void Main()
        {
            Console.Write("Enter n = ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

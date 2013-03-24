using System;

namespace _12.Square_of_numbers
{
    class SquareOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter N (N<20) = ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0 && n < 20)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int column = row ; column <= row + (n-1); column++)
                    {
                        Console.Write("{0,3} ", column);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
}

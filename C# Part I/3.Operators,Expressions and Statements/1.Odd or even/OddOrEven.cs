using System;

namespace _1.Odd_or_even
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("a = ");
            int a; 
            bool parseSucsess = int.TryParse(Console.ReadLine(), out a);
            if (parseSucsess == true)
            {
                if ((a % 2) == 0)
                {
                    Console.WriteLine("The {0} is even.", a);
                }
                else
                {
                    Console.WriteLine("The {0} is odd.", a);
                }
            }
            else 
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

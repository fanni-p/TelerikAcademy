using System;

namespace _2.Division_by_5_and_7
{
    class DivisionBy5And7
    {
        static void Main()
        {
            Console.Write("a = ");
            int a;
            bool parseSucsess = int.TryParse(Console.ReadLine(), out a);
            if (parseSucsess == true) 
            {
                if (((a % 7) == 0) && ((a % 5) == 0) == true) 
                {
                    Console.WriteLine("The number can be divided by 5 and 7 in the same time.");
                }
                else
                {
                    Console.WriteLine("The number can't be divided by 5 and 7 in the same time.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

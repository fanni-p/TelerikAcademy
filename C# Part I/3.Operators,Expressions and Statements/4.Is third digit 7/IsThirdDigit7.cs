using System;

namespace _4.Is_third_digit_7
{
    class IsThirdDigit7
    {
        static void Main()
        {
            int thirdDigit;
            Console.Write("Enter a number:");
            bool parseSucsess = int.TryParse(Console.ReadLine(), out thirdDigit);
            if (parseSucsess == true)
            {
                thirdDigit = Math.Abs(thirdDigit);
                thirdDigit = thirdDigit / 100;
                if (thirdDigit % 10 == 7)
                {
                    Console.WriteLine("The third digit is 7.");
                }
                else
                {
                    Console.WriteLine("The third digit isn't 7.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}

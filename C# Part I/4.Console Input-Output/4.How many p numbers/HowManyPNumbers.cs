using System;

namespace _4.How_many_p_numbers
{
    class HowManyPNumbers
    {
        static void Main()
        {
            int count = 0;
            Console.Write("Enter first positive number:");
            uint firstNumber = uint.Parse(Console.ReadLine());
            Console.Write("Enter second positive number:");
            uint secondNumber = uint.Parse(Console.ReadLine());
            for (uint i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0) count++;
            }
            Console.WriteLine("Numbers that the reminder of the division by 5 is 0 - p({0},{1}) = {2}", firstNumber,secondNumber,count);
        }
    }
}

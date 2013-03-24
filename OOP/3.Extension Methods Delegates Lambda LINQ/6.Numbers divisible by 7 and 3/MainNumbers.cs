using System;
using System.Linq;

namespace _6.Numbers_divisible_by_7_and_3
{
    class MainNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 12, 14, 21, 5, 3, 7, 42, 126, 210, 231};

            var divisibleLinq = from number in numbers
                                where number % 21 == 0
                                select number;

            var divisibleLambda = numbers.Where(x => x % 21 == 0);

            Console.WriteLine("Numbers divisible by 3 and 7 with Lambda expression:");
            foreach (var number in divisibleLambda)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            Console.WriteLine("Numbers divisible by 3 and 7 with LINQ query:");
            foreach (var number in divisibleLinq)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }
    }
}

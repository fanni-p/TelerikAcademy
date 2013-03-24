using System;

namespace _1.Exchange_values
{
    class ExchangeValues
    {
        static void Main()
        {
            Console.Write("Enter the first value: ");
            int firstValue = int.Parse(Console.ReadLine());
            Console.Write("Enter the second value: ");
            int secondValue = int.Parse(Console.ReadLine());
            int gratherValue = firstValue;
            if (gratherValue > secondValue)
            {
                firstValue = secondValue;
                secondValue = gratherValue;
                Console.WriteLine("The first value is grather then the second value.");
                Console.WriteLine("The new value of the first value is {0}", firstValue);
                Console.WriteLine("The new value of the second value is {0}", secondValue);
            }
            else
            {
                Console.WriteLine("The second value is grather then the first value.");
            }
        }
    }
}

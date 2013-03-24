using System;

namespace _5.Min_Max
{
    class MinMax
    {
        static void Main()
        {
            Console.Write("Enter first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number:");
            int secondNumber = int.Parse(Console.ReadLine());
            int minValue = Math.Min(firstNumber, secondNumber);
            int maxValue = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The max value is {0} and the min value is {1}.", maxValue, minValue);
        }
    }
}

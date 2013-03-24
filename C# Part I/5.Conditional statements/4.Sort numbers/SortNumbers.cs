using System;

namespace _4.Sort_numbers
{
    class SortNumbers
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            if (firstNumber == secondNumber && secondNumber == thirdNumber && firstNumber == thirdNumber)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else if (firstNumber == secondNumber)
            {
                if (firstNumber > thirdNumber)
                {
                    Console.WriteLine("{0} < {1} = {2}", thirdNumber, firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("{0} = {1} < {2}", firstNumber, secondNumber, thirdNumber);
                }
            }
            else if (secondNumber == thirdNumber)
            {
                if (secondNumber > firstNumber)
                {
                    Console.WriteLine("{0} < {1} = {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} = {1} < {2}", secondNumber, thirdNumber, firstNumber);
                }
            }
            else if (firstNumber == thirdNumber)
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine("{0} < {1} = {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} = {1} < {2}", thirdNumber, firstNumber, secondNumber);
                }
            }
            else if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                if (secondNumber < thirdNumber)
                {
                    Console.WriteLine("{0} < {1} < {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} < {1} < {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                if (firstNumber < thirdNumber)
                {
                    Console.WriteLine("{0} < {1} < {2}", secondNumber, firstNumber, thirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} < {1} < {2}", secondNumber, thirdNumber, firstNumber);
                }
            }
            else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
            {
                if (firstNumber < secondNumber)
                {
                    Console.WriteLine("{0} < {1} < {2}", thirdNumber, firstNumber, secondNumber);
                }
                else
                {
                    Console.WriteLine("{0} < {1} < {2}", thirdNumber, secondNumber, firstNumber);
                }
            }
        }
    }
}

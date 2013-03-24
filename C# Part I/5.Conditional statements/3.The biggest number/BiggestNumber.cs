using System;

namespace _3.The_biggest_number
{
    class BiggestNumber
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            if (firstNumber == secondNumber && secondNumber == thirdNumber && firstNumber == thirdNumber)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The first number is the biggest number.");
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The second number is the biggest number.");
            }
            else if (firstNumber == secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("First and second number are bigger than third number.");
            }
            else if (secondNumber == thirdNumber && secondNumber > firstNumber)
            {
                Console.WriteLine("Second and third number are bigger than first number.");
            }
            else if (firstNumber == thirdNumber && firstNumber > secondNumber)
            {
                Console.WriteLine("First and third number are bigger than second number.");
            }
            else
            {
                Console.WriteLine("The third number is the biggest number.");
            }
        }
    }
}

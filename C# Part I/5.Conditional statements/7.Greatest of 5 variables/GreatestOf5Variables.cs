using System;

namespace _7.Greatest_of_5_variables
{
    class GreatestOf5Variables
    {
        static void Main()
        {
            Console.Write("Enter 1 number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2 number: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter 3 number: ");
            int number3 = int.Parse(Console.ReadLine());
            Console.Write("Enter 4 number: ");
            int number4 = int.Parse(Console.ReadLine());
            Console.Write("Enter 5 number: ");
            int number5 = int.Parse(Console.ReadLine());
            int greatest = number1;
            if (greatest <= number2)
            {
                greatest = number2;
            }
            if (greatest <= number3)
            {
                greatest = number3;
            }
            if (greatest <= number4)
            {
                greatest = number4;
            }
            if (greatest <= number5)
            {
                greatest = number5;
            }
            Console.WriteLine("The greatest number is {0}", greatest);
        }
    }
}

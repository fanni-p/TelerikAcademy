using System;

namespace _2.Show_sign_of_the_product
{
    class ShowSignOfTheProduct
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            int negativeCount=0;
            if (firstNumber < 0)
            {
                negativeCount++;
            }
            if (secondNumber < 0)
            {
                negativeCount++;
            }
            if (thirdNumber < 0)
            {
                negativeCount++;
            }
            if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
            {
                Console.WriteLine("The product is 0.");
            }
            else if (negativeCount % 2 == 0)
            {
                Console.WriteLine("The sign of the product is \"+\"");
            }
            else
            {
                Console.WriteLine("The sign of the product is \"-\"");
            }
        }
    }
}

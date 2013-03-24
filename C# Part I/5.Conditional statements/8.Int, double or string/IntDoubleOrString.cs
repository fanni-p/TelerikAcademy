using System;

namespace _8.Int__double_or_string
{
    class IntDoubleOrString
    {
        static void Main()
        {
            Console.WriteLine("Enter a type of variable: \n 1 - integer \n 2 - double \n 3 - string");
            byte type = byte.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.Write("Enter integer: ");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", intNumber + 1);
                    break;
                case 2:
                    Console.Write("Enter double: ");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: {0}", doubleNumber + 1);
                    break;
                case 3:
                    Console.Write("String: ");
                    string strVariable = Console.ReadLine();
                    Console.WriteLine("Result: {0}*", strVariable);
                    break;
            }
        }
    }
}

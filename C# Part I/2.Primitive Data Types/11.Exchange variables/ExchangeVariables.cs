using System;

namespace _11.Exchange_variables
{
    class ExchangeVariables
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("new a = {0}, new b = {1}", a, b);
        }
    }
}

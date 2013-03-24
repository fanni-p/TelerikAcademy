using System;

namespace _13.Exchanges_bits
{
    class ExchangesBits
    {
        static void Main()
        {
            Console.Write("Enter unsigned integer: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("Before exchange:{0}",Convert.ToString(number, 2).PadLeft(32, '0'));

            uint firstGroup = (number & (7 << 3));
            uint secondGroup = (number & (7 << 24));
            number = number & (~(7u << 24));
            number = number & (~(7u << 3));
            number = number | (firstGroup << 21);
            number = number | (secondGroup>>21);

            Console.WriteLine("After exchange:{0}", Convert.ToString(number, 2).PadLeft(32, '0'));
 
        }
    }
}

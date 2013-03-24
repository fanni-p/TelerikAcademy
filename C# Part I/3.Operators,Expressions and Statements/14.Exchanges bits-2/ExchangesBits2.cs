using System;

namespace _14.Exchanges_bits_2
{
    class ExchangesBits2
    {
        static void Main()
        {
            Console.Write("Enter unsigned integer: n = ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter position p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Enter position q = ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Enter length k = ");
            int k = int.Parse(Console.ReadLine());
            int firstGroup, secondGroup;
        
            Console.WriteLine("Before exchange:{0}", Convert.ToString(number, 2).PadLeft(32, '0'));
            for (int i = 0; i < k; i++)
            {
                firstGroup = (number & (1 << p + i)) >> p + i;
                secondGroup = (number & (1 << q + i)) >> q + i;
                number = number & (~(1 << p + i));
                number = number | (secondGroup << p + i);
                number = number & (~(1 << q + i));
                number = number | (firstGroup << q + i);
            }
            Console.WriteLine("After exchange:{0}", Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}

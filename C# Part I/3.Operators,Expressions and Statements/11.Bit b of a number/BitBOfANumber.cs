using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Bit_b_of_a_number
{
    class BitBOfANumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number i = ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Enter a number of the bit b = ");
            int b = int.Parse(Console.ReadLine());
            int mask = 1 << b;
            int iAndMask = i & mask;
            int bit = iAndMask >> b;
            Console.WriteLine("The {0} bit of the number {1} is {2}", b, i, bit);
        }
    }
}

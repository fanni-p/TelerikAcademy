using System;

namespace _5.Bit_3_of_a_number
{
    class Bit3OfANumber
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            if (bit == 1)
            {
                Console.WriteLine("The 3th bit of the number is 1.");
            }
            else
            {
                Console.WriteLine("The 3th bit of the number is 0.");
            }
        }
    }
}

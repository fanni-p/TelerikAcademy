using System;


namespace _10.Bit_p_of_a_number
{
    class BitPOfANumber
    {
        static void Main()
        {
            Console.Write("Enter a number: v=");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter the p position: p=");
            int p = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            int vAndMask = v & mask;
            int bit = vAndMask >> p;
            bool hasValue1 = (bit==1);
            Console.WriteLine("The {0} bit in {1} has value 1 - {2}",p,v,hasValue1);
        }
    }
}

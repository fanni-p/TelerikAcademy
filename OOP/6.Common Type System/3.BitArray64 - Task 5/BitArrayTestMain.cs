using System;

namespace _3.BitArray64
{
    class BitArrayTestMain
    {
        static void Main()
        {
            BitArray64 number = new BitArray64(654231123);
            BitArray64 number2 = new BitArray64(654231123); // Add second BitArray

            Console.WriteLine("Print bits of number: " + number.Number);
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            // Testing Equals
            Console.WriteLine("Are numbers equal: " + number.Equals(number2));
            Console.WriteLine(new string('-', 80));

            // Print bit of index
            Console.WriteLine("Print bit of index[4]: " + number[4]);
            Console.WriteLine(new string('-', 80));

            // Print hash code
            Console.WriteLine("Print Hash Code: " + number.GetHashCode());
            Console.WriteLine(new string('-', 80));

            // Change bit
            number2[10] = 0;
            // Print the changed number and his bits
            Console.WriteLine("Changed number: " + number2.Number);
            foreach (var bit in number2)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 80));

            // Testing Equals after changing bit
            Console.WriteLine("Are numbers equal after changing bit: " + number.Equals(number2));
            Console.WriteLine(new string('-', 80));
        }
    }
}

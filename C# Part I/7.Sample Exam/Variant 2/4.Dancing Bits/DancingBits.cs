using System;

namespace _4.Dancing_Bits
{
    class DancingBits
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int kCount = 0;
            int length = 0;
            int lastbit = -1;
            for (int i = 0; i < n; i++)
            {
                int nextN = int.Parse(Console.ReadLine());
                bool isOne = false;
                for (int bit = 31; bit >= 0; bit--)
                {
                    int bitValue = (nextN >> bit) & 1;
                    if (bitValue == 1)
                    {
                        isOne = true;
                    }
                    if (isOne)
                    {
                        if (lastbit == bitValue)
                        {
                            length++;
                        }
                        else
                        {
                            if (length == k)
                            {
                                kCount++;
                            }
                            length = 1;
                        }
                        lastbit = bitValue;
                    }
                }
            }
            if (length == k)
            {
                kCount++;
            }
            Console.WriteLine(kCount);
        }
    }
}

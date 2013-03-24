using System;

namespace _4.We_All_Love_Bits
{
    class WeAllLoveBits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                int newP = 0;
                while (p > 0)
                {
                    newP <<= 1;
                    if ((p & 1) == 1)
                    {
                        newP |= 1;
                    }
                    p >>= 1;
                }
                Console.WriteLine(newP);
            }
        }
    }
}

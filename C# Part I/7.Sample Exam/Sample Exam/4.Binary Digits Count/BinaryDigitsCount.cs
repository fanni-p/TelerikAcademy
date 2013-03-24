using System;

namespace _4.Binary_Digits_Count
{
    class BinaryDigitsCount
    {
        static void Main()
        {
            byte b = byte.Parse(Console.ReadLine());
            ushort n = ushort.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                for (long n1 = long.Parse(Console.ReadLine()); n1!=0; n1 = n1 >> 1)
                {
                    if ((n1&1)== b)
                    {
                        count++;
                    }
                    
                }
                Console.WriteLine(count);
            }
        }
    }
}

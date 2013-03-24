using System;

namespace _5.Fall_Dawn
{
    class FallDown
    {
        static void Main()
        {
            int mask = 0;
            int n0 = int.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            int n6 = int.Parse(Console.ReadLine());
            int n7 = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 5; i++)
            {
                mask = n1;
                n1 = n0 | n1;
                n0 &= mask;
                mask = n2;
                n2 = n1 | n2;
                n1 &= mask;
                mask = n3;
                n3 = n2 | n3;
                n2 &= mask;
                mask = n4;
                n4 = n3 | n4;
                n3 &= mask;
                mask = n5;
                n5 = n4 | n5;
                n4 &= mask;
                mask = n6;
                n6 = n5 | n6;
                n5 &= mask;
                mask = n7;
                n7 = n6 | n7;
                n6 &= mask;
            }
            Console.WriteLine(n0);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
        }
    }
}

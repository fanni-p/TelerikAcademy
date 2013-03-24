using System;

namespace _12.Set_value_V_to_position_P
{
    class SetValueVToPositionP
    {
        static void Main()
        {
            Console.Write("Enter a number n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter a value v (1 or 0) = ");
            int v = int.Parse(Console.ReadLine());
            Console.Write("Enter a position p = ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Before: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            if (v == 0)
            {
                n = n & (~(1 << p));
            }
            else
            {
                n = n | (1 << p);
            }
            Console.WriteLine("After:  {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        }
    }
}

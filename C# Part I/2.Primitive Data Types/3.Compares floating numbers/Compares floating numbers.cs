using System;

namespace _3.Compares_floating_numbers
{
    class ComparesFloatingNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number A=");
            decimal A = decimal.Parse(Console.ReadLine());
            Console.Write("Enter a number B=");
            decimal B = decimal.Parse(Console.ReadLine());
            Console.WriteLine("A=B-{0}",Equals(decimal.Round(A, 6), decimal.Round(B, 6)));
        }
    }
}

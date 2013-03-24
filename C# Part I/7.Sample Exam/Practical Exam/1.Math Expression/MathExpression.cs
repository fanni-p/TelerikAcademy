using System;
using System.Threading;
using System.Globalization;

namespace _1.Math_Expression
{
    class MathExpression
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double expression = 0;
            int m1 = (int)m % 180;
            expression = (((n*n) + (1 / (m * p)) + 1337) / (n - (128.523123123 * p))) + Math.Sin(m1);
            Console.WriteLine("{0:F6}",expression);
        }
    }
}

using System;

namespace _3.Sand_glass
{
    class SandGlass
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            string dot = "";
            string star = "";
            for (int i = n; i > 1; i -= 2)
            {
                dot = new string('.', (n - i) / 2);
                star = new string('*', i);
                Console.WriteLine(dot + star + dot);
            }
            for (int i = 1; i <= n; i += 2)
            {
                dot = new string('.', (n - i) / 2);
                star = new string('*', i);
                Console.WriteLine(dot + star + dot);
            }
       }
    }
}

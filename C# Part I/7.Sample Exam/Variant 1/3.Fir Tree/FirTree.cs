using System;

namespace _3.Fir_Tree
{
    class FirTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string dot = "";
            string star = "";
            string tree = new string('.', n - 2) + "*" + new string('.', n - 2);

            for (int i = 1; i <= 2 * n - 3; i += 2)
            {
                dot = new string('.', ((2 * n - 3) - i) / 2);
                star = new string('*', i);
                Console.WriteLine(dot + star + dot);
            }
            Console.WriteLine(tree);
        }
    }
}

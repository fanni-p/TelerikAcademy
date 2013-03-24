using System;

namespace Matrix
{
    class Program
    {
        static void Main()
        {
            Matrix<int> m1 = new Matrix<int>(new[,] { { 1, 1 }, { 1, 1 } });
            Matrix<int> m2 = new Matrix<int>(new[,] { { 3, 3 }, { 3, 3 } });

            Console.WriteLine("First Matrix");
            Console.WriteLine(m1);

            Console.WriteLine("Second Matrix");
            Console.WriteLine(m2);

            Console.WriteLine("First + Second");
            Console.WriteLine(m1 + m2);

            Console.WriteLine("First - Second");
            Console.WriteLine(m1 - m2);

            Console.WriteLine("First * Second");
            Console.WriteLine(m1 * m2);

            if (m1)
            {
                Console.WriteLine("There are no zeros.");
            }
            else
            {
                Console.WriteLine("There are some zeros.");
            }

            Console.WriteLine();
        }
    }
}

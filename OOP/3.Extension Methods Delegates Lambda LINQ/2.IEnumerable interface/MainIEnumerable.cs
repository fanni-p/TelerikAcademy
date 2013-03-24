using System;

namespace _2.IEnumerable_interface
{
    class MainIEnumerable
    {
        static void Main()
        {
            int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Max: {0}", elements.Max<int>());
            Console.WriteLine("Min: {0}", elements.Min<int>());
            Console.WriteLine("Sum: {0}", elements.Sum<int>());
            Console.WriteLine("Product: {0}", elements.Product<int>());
            Console.WriteLine("Average: {0}", elements.Average<int>());
        }
    }
}

using System;
using System.Text;

namespace _12.ASCII_Table
{
    class ASCIITable
    {
        static void Main()
        {
            int a = 32;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("ASCII printable characters:");
                while (a <= 127)
                {
                    Console.WriteLine("{0} = {1}", a, (char)a);
                    a++;
                }
            a = 128;
            Console.WriteLine("The extended ASCII codes:");
                while (a <= 255)
                {
                    Console.WriteLine("{0} = {1}", a, (char)a);
                    a++;
                }
        }
    }
}

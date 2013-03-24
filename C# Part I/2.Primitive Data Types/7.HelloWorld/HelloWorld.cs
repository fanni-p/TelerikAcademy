using System;

namespace _7.HelloWorld
{
    class HelloWorld
    {
        static void Main()
        {
            string a = "Hello";
            string b = "World";
            object HW = a + " " + b;
            string c = Convert.ToString(HW);
            Console.WriteLine(c);
        }
    }
}

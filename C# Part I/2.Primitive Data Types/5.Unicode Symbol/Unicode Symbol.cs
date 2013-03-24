using System;

namespace _5.Unicode_Symbol
{
    class UnicodeSymbol
    {
        static void Main()
        {
            int symbol = 0x0048;
            Console.WriteLine("The symbol of '{0}' is: {1}", symbol, (char)symbol);
        }
    }
}

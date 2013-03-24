using System;


namespace _9.CopyrightSymbol
{
    class CopyrightSymbol
    {
        static void Main()
        {
            char symbol = (char)0x00A9;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(" " + " " + " " + "{0}" + " " + " " + " ",symbol);
            Console.WriteLine(" " + " " + "{0}" + " " + "{0}" + " " + " ", symbol);
            Console.WriteLine(" " + "{0}" + " " + " " + " " + "{0}" + " ", symbol);
            Console.WriteLine("{0}" + " " + "{0}" + " " + "{0}" + " " + "{0}", symbol);
        }
    }
}

using System;

namespace _9.QuotedStrings
{
    class QuotedStrings
    {
        static void Main()
        {
            string a = "The use of quotations causes difficulties.";
            string b = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine("String without quotes:\n{0}", a);
            Console.WriteLine("String with quotes:\n{0}", b);
        }
    }
}

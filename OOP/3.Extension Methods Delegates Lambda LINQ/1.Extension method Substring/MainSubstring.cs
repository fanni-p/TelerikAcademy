using System;
using System.Text;

namespace _1.Extension_method_Substring
{
    class MainSubstring
    {
        static void Main()
        {
            StringBuilder testing = new StringBuilder(); // Testing Extension method Substring
            testing.Append("Test of task 1");
            Console.WriteLine(testing.Substring(0,4));

            string test = "Test of task 1"; // Check with string.Substring if the result is correct
            Console.WriteLine(test.Substring(0,4));
        }
    }
}

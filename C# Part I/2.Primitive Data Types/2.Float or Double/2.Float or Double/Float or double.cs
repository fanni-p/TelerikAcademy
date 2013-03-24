using System;

namespace _2.Float_or_Double
{
    class FloatOrDouble
    {
        static void Main()
        {
            double firstValue = 34.567839023;
            float secondValue = 12.345f;
            double thirdValue = 8923.1234857;
            float fourthValue = 3456.091f;
            Console.WriteLine("This is float:\n{0}\n{1}", secondValue, fourthValue);
            Console.WriteLine("This is double:\n{0}\n{1}", firstValue, thirdValue);
        }
    }
}
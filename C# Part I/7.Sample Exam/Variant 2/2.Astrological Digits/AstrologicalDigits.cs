using System;
using System.Globalization;
using System.Threading;

namespace _2.Astrological_Digits
{
    class AstrologicalDigits
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string num = Console.ReadLine();
            int newNum = 0;
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (char.IsDigit(num[i]))
                {
                    sum += (num[i] - '0');
                }
            }
            while (sum > 9)
            {
                newNum = sum % 10;
                sum = sum / 10;
                sum += newNum;
            }
            Console.WriteLine(sum);
        }
    }
}

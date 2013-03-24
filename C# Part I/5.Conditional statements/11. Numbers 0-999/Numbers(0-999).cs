using System;

namespace _11.Numbers_0_999
{
    class NumbersTo999
    {
        static void Main()
        {
            Console.Write("Enter a number between [0-999]: ");
            int number = int.Parse(Console.ReadLine());
            int units = number % 10;
            int tens = (number / 10) % 10;
            int hundreds = number / 100;
            if (units == 0 && hundreds == 0 && tens == 0)
            {
                Console.Write("zero");
            }
            switch (hundreds)
            {
                case 1: Console.Write("one hundred "); break;
                case 2: Console.Write("two hundred "); break;
                case 3: Console.Write("three hundred "); break;
                case 4: Console.Write("four hundred "); break;
                case 5: Console.Write("five hundred "); break;
                case 6: Console.Write("six hundred "); break;
                case 7: Console.Write("seven hundred "); break;
                case 8: Console.Write("eight hundred "); break;
                case 9: Console.Write("nine hundred "); break;
            }
            if (tens == 0 && units == 0)
            {
                Console.Write("");
            }
            else
            {
                if (hundreds != 0 && (tens != 0 || (tens == 0 && units != 0)))
                {
                    Console.Write("and ");
                }
                switch (tens)
                {
                    case 0: break;
                    case 1: Console.Write("ten"); break;
                    case 2: Console.Write("twenty "); break;
                    case 3: Console.Write("thirty "); break;
                    case 4: Console.Write("forty "); break;
                    case 5: Console.Write("fifty "); break;
                    case 6: Console.Write("sixty "); break;
                    case 7: Console.Write("seventy "); break;
                    case 8: Console.Write("eighty "); break;
                    case 9: Console.Write("ninety "); break;
                }
                if (tens != 1)
                {
                    switch (units)
                    {
                        case 1: Console.Write("one"); break;
                        case 2: Console.Write("two"); break;
                        case 3: Console.Write("three"); break;
                        case 4: Console.Write("four"); break;
                        case 5: Console.Write("five"); break;
                        case 6: Console.Write("six"); break;
                        case 7: Console.Write("seven"); break;
                        case 8: Console.Write("eight"); break;
                        case 9: Console.Write("nine"); break;
                    }
                }
                else if (tens == 1)
                {
                    switch (units)
                    {
                        case 1: Console.Write("eleven"); break;
                        case 2: Console.Write("twelve"); break;
                        case 3: Console.Write("thirteen"); break;
                        case 4: Console.Write("fourteen"); break;
                        case 5: Console.Write("fifteen"); break;
                        case 6: Console.Write("sixteen"); break;
                        case 7: Console.Write("seventeen"); break;
                        case 8: Console.Write("eighteen"); break;
                        case 9: Console.Write("nineteen"); break;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}

